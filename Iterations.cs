using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {
        /*
           Welcome to Interation
           Down below you will find instructions for code to write.
           As you write and save your code, you can look in your terminal where you
           ran `dotnet watch test` to see if your code is working. The tests continuously check
           your work each time you save. If a test is failing you have not yet completed that method
           Once you finish a method and have it correct, the test will tell you how
           the next method is working.
        */


        //  
        // 1) Complete the method named `yelling` that takes an list of
        //    words as an argument and returns a new list with all
        //    the words forced to uppercase.
        //
        public static IEnumerable<string> Yelling(List<string> words)


        {
            var newList = words.Select(word => word.ToUpper());
            return newList;
        }





        // 
        // 2) Complete the method named `Double` that takes an list of
        //    numbers as an argument and returns a new list with all
        //    the numbers multiplied by 2.
        // 
        public static IEnumerable<int> Double(List<int> numbers)
        {
            var data = new List<int> { 1, 2, 3, 4, 5 };
            var doubleData = data.Select(data => data * 2);
            return doubleData;
        }


        // 
        // 3) Complete the method `StringyIndexes` that takes an list of
        //    strings as an argument and returns a new list with each
        //    string suffixed with " is at index X" where X is the index
        //    of the element.
        // 
        public static IEnumerable<string> StringyIndexes(List<string> data)
        {
            var newIndexList = data.Select((dataItem, selectIndex) => $"{dataItem} is at index {selectIndex}");
            return newIndexList;
        }
        // 
        // 4) Complete the method OnlyTheEvenSurvive that accepts an list of
        //    numbers and returns only the elements that are even.
        // 
        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> data)
        {
            var evenData = new List<int> { 42, 50, 100, 5, -43, 17, 44 }.Where(data => data % 2 == 0);
            return evenData;
        }
        // 
        // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts an
        //    list of numbers and returns only the elements at indexes that
        //    are even.
        // 
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> data)
        {
            //var dataAtEvenIndex = new List<int>{ 31, 67, 64, 96, 14, 24, 43, 51, 48, 80, 58, 43, 64, 84, 98, 99, 69, 93, 5, 32, 29, 4, 28, 18, 86, 22, 20, 74, 35, 27, 85, 79, 65, 32, 56, 94, 93, 20, 29, 22, 72 };

            var everySecond = new List<int> { 31, 67, 64, 96, 14, 24, 43, 51, 48, 80, 58, 43, 64, 84, 98, 99, 69, 93, 5, 32, 29, 4, 28, 18, 86, 22, 20, 74, 35, 27, 85, 79, 65, 32, 56, 94, 93, 20, 29, 22, 72 }.Where((data, element) => element % 2 == 0);
            return everySecond;
        }


        // 
        // 6) Complete the method BestMoviesOfTheYear that accepts an list of
        //    movie objects AND a year and returns the names of movies that are
        //    from that year AND have a score more than 90.
        // 
        // A movie object looks like this:
        // 
        // {
        //   name: "Get Out",
        //   year: "2017",
        //   score: 99
        // }
        // 
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> movies, int year)
        {
            //get all movies with scores greater than 90
            //of those with scores > 90, list by year 2014 as a variable , then do by 17 as another variable
            //then combine lists as a master list

            var bestMovieOfTheYear = movies.Where(movie => movie.Score > 90 && movie.Year == year);
            var nameOfBestMovieOfTheYear = bestMovieOfTheYear.Select(movie => movie.Name);
            return nameOfBestMovieOfTheYear;
        }


        // 
        // 7) Complete the method EveryoneIsOdd that accepts an list of
        //    numbers and returns true if every element of the list is odd.
        // 
        public static bool EveryoneIsOdd(List<int> data)
        {

            var areAllIntegersOdd = data.All(dataItem => dataItem % 2 > 0);
            return areAllIntegersOdd;
        }


        // 
        // 8) Complete the method FindTheNeedle that accepts an list of
        //    strings and returns the one string that contains the word
        //    `needle`.
        // 
        public static string FindTheNeedle(List<string> data)
        {
            throw new System.NotImplementedException();
        }


        // 
        // 9) Complete the method FindTheNeedleIndex that accepts an list of
        //    strings and returns the index of the string that contains
        //    the word `needle` inside.
        // 
        public static int FindTheNeedleIndex(List<string> data)
        {
            throw new System.NotImplementedException();
        }


        // 
        // 10) Complete the method SomeoneToLove that accepts an list of
        //     strings and returns true if at least one string is exactly
        //     four characters long.
        // 
        public static bool SomeoneToLove(List<string> data)
        {
            throw new System.NotImplementedException();
        }
    }
}