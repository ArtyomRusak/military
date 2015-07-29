using System;
using System.Collections.Generic;
using System.Linq;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Models
{
    public class BaseCalculationStrategy
    {
        public ResultConfig ResultConfig { get; private set; }
        public TestConfig TestConfig { get; set; }
        public IDictionary<Question, IList<IAnswerItem>> Answers { get; private set; }
        public IList<IResultItem> Results { get; private set; }

        public BaseCalculationStrategy(ResultConfig resultConfig, TestConfig testConfig,
            IDictionary<Question, IList<IAnswerItem>> answers)
        {
            this.ResultConfig = resultConfig;
            this.TestConfig = testConfig;
            this.Answers = answers;
            this.Results = new List<IResultItem>();
        }

        public Result GetResult()
        {
            this.CalculateResults();

            var result = new Result
            {
                Date = DateTime.Now,
                CountOfRightAnswers = this.Results.Count(mod => mod.IsRight),
                CountOfWrongAnswers = this.Results.Count(mod => mod.IsRight == false),
                Mark = this.Results.Sum(mod => mod.Koefficient)/this.TestConfig.NumberOfQuestions,
                ResultConfig = this.ResultConfig
            };
            result.Success = ((result.CountOfRightAnswers / this.TestConfig.NumberOfQuestions) * 100) > this.ResultConfig.PercentOfRightAnswers;

            return result;
        }

        private void CalculateResults()
        {
            foreach (var answer in Answers)
            {
                ResultItem resultItem;
                var correctAnswers =
                    answer.Key.Variants.OrderBy(ans => ans.Id)
                        .Where(ans => ans.IsRight)
                        .Select(ans => ans.Id)
                        .ToList();
                var answers =
                    answer.Value.Where(mod => mod.CheckState)
                        .OrderBy(mod => mod.VariantId)
                        .Select(mod => mod.VariantId)
                        .ToList();
                var equalityResult = correctAnswers.SequenceEqual(answers);
                if (this.ResultConfig.FullAnswer)
                {
                    resultItem = equalityResult
                        ? new ResultItem
                        {
                            CountOfRightAnswers = answers.Count,
                            CountOfWrongAnswers = 0,
                            IsRight = true,
                            Koefficient = 1
                        }
                        : this.GetResultItem(answers, correctAnswers,
                            answers.Count > correctAnswers.Count);
                }
                else
                {
                    if (equalityResult)
                    {
                        resultItem = new ResultItem
                        {
                            CountOfRightAnswers = answers.Count,
                            CountOfWrongAnswers = 0,
                            IsRight = true,
                            Koefficient = 1
                        };
                    }
                    else
                    {
                        resultItem = this.GetResultItem(answers, correctAnswers, answers.Count > correctAnswers.Count);
                        resultItem.IsRight = false;
                        resultItem.Koefficient = 0;
                    }
                }

                this.Results.Add(resultItem);
            }
        }

        private ResultItem GetResultItem(ICollection<int> answers, ICollection<int> correctAnswers, bool answersGreater)
        {
            var resultItem = new ResultItem();

            foreach (var checkCorrectness in answers.Select(correctAnswers.Contains))
            {
                if (checkCorrectness)
                {
                    resultItem.CountOfRightAnswers++;
                }
                else
                {
                    resultItem.CountOfWrongAnswers++;
                }
            }

            if (answersGreater)
            {
                resultItem.CountOfWrongAnswers = resultItem.CountOfWrongAnswers +
                                                 (correctAnswers.Count - answers.Count);
            }

            if (this.ResultConfig.IgnoreWrongAnswers)
            {
                resultItem.Koefficient = resultItem.CountOfRightAnswers / correctAnswers.Count;
            }
            else
            {
                resultItem.Koefficient = (resultItem.CountOfRightAnswers - resultItem.CountOfWrongAnswers) /
                                         correctAnswers.Count;
            }

            resultItem.IsRight = resultItem.Koefficient > 0;

            return resultItem;
        }
    }
}