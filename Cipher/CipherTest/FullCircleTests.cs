﻿using Cipher;
using Xunit;

namespace CipherTest
{
    public class FullCircleTests
    {
        string PlainText = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG".ToLower();
        int ShiftValue = 26;

        public void AssertResults(string encrypted, string decrypted)
        {
            Assert.Equal(PlainText, encrypted);
            Assert.Equal(PlainText, decrypted);
        }

        [Fact]
        public void WithStringBuilder()
        {
            var encrypted = Ciphers.WithStringBuilder(PlainText, ShiftValue);
            var decrypted = Ciphers.WithStringBuilder(encrypted, -ShiftValue);

            AssertResults(encrypted, decrypted);
        }

        [Fact]
        public void WithLinqStringConstructor()
        {
            var encrypted = Ciphers.WithLinqStringConstructor(PlainText, ShiftValue);
            var decrypted = Ciphers.WithLinqStringConstructor(encrypted, -ShiftValue);

            AssertResults(encrypted, decrypted);
        }

        [Fact]
        public void StringBuilderLinqToArray()
        {
            var encrypted = Ciphers.StringBuilderLinqToArray(PlainText, ShiftValue);
            var decrypted = Ciphers.StringBuilderLinqToArray(encrypted, -ShiftValue);

            AssertResults(encrypted, decrypted);
        }

        [Fact]
        public void AppendToEmptyString()
        {
            var encrypted = Ciphers.AppendToEmptyString(PlainText, ShiftValue);
            var decrypted = Ciphers.AppendToEmptyString(encrypted, -ShiftValue);

            AssertResults(encrypted, decrypted);
        }

        [Fact]
        public void AppendToString()
        {
            var encrypted = Ciphers.AppendToString(PlainText, ShiftValue);
            var decrypted = Ciphers.AppendToString(encrypted, -ShiftValue);

            AssertResults(encrypted, decrypted);
        }

        [Fact]
        public void WithLinq()
        {
            var encrypted = Ciphers.WithLinq(PlainText, ShiftValue);
            var decrypted = Ciphers.WithLinq(encrypted, -ShiftValue);

            AssertResults(encrypted, decrypted);
        }
    }
}
