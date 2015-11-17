﻿namespace AssertLibrary
{
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;

    public static partial class AssertThat
    {
        /// <summary>
        /// Asserts that the given number is positive.
        /// </summary>
        /// <param name="n">Number to check if it's positive</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK.")]
        public static void IsPositive(int n, string name = null)
        {
            Debug.Assert(n > 0, IsPositiveMessage(name));
        }

        /// <summary>
        /// Asserts that the given number is positive.
        /// </summary>
        /// <param name="n">Number to check if it's positive</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK.")]
        public static void IsPositive(long n, string name = null)
        {
            Debug.Assert(n > 0, IsPositiveMessage(name));
        }

        /// <summary>
        /// Asserts that the given number is positive.
        /// </summary>
        /// <param name="n">Number to check if it's positive</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK.")]
        public static void IsPositive(float n, string name = null)
        {
            Debug.Assert(n > 0, IsPositiveMessage(name));
        }

        /// <summary>
        /// Asserts that the given integer is positive.
        /// </summary>
        /// <param name="n">Number to check if it's positive</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK.")]
        public static void IsPositive(double n, string name = null)
        {
            Debug.Assert(n > 0, IsPositiveMessage(name));
        }

        /// <summary>
        /// Asserts that the given number is positive.
        /// </summary>
        /// <param name="n">Number to check if it's positive</param>
        /// <param name="name">Variable name to include in the error message (optional)</param>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "That's OK.")]
        public static void IsPositive(decimal n, string name = null)
        {
            Debug.Assert(n > 0, IsPositiveMessage(name));
        }

        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "False positive.")]
        private static string IsPositiveMessage(string name)
        {
            return name == null ?
                "Should be positive at this point." :
                string.Format(CultureInfo.CurrentCulture, "\"{0}\" should be positive at this point.", name);
        }
    }
}
