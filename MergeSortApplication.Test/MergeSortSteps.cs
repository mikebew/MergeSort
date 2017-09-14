using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MergeSortApplication.Test
{
    [Binding]
    public class MergeSortSteps
    {
        private MergeSort mergeSort = new MergeSort();
        private int[] initialArray = null;
        private int[] sortedArrary = null;

        [Given(@"I have entered (.*) into the merge sort")]
        public void GivenIHaveEnteredIntoTheMergeSort(string paramString)
        {
            initialArray = paramString.Split(',').Select(x => Convert.ToInt32(x)).ToArray();
        }
        
        [When(@"I press sort")]
        public void WhenIPressSort()
        {
            Task<int[]> sortTask = mergeSort.Sort(initialArray);
            sortedArrary = sortTask.Result;
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string paramString)
        {
            CollectionAssert.AreEqual(paramString.Split(',').Select(x => Convert.ToInt32(x)).ToArray(), sortedArrary);
        }
    }
}
