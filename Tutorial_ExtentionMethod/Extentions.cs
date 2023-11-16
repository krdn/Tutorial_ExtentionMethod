// Define extension methods for IMyInterface.
namespace Extensions
{
    using DefineIMyInterface;
    using System;

    // The following extension methods can be accessed by instances of any
    // class that implements IMyInterface.
    public static class Extension
    {
        public static void MethodA(this IMyInterface myInterface, int i)
        {
            Console.WriteLine
                ("Extension.MethodA(this IMyInterface myInterface, int i)");
        }

        public static void MethodA(this IMyInterface myInterface, string s)
        {
            Console.WriteLine
                ("Extension.MethodA(this IMyInterface myInterface, string s)");
        }

        // This method is never called in ExtensionMethodsDemo1, because each
        // of the three classes A, B, and C implements a method named MethodB
        // that has a matching signature.
        public static void MethodB(this IMyInterface myInterface)
        {
            Console.WriteLine
                ("Extension.MethodB(this IMyInterface myInterface)");
        }
    }



    public static class Enumerable2
    {
        #nullable enable
        ///// <summary>Applies an accumulator function over a sequence.</summary>
        ///// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
        ///// <param name="func">An accumulator function to be invoked on each element.</param>
        ///// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        ///// <exception cref="T:System.ArgumentNullException">
        ///// <paramref name="source" /> or <paramref name="func" /> is <see langword="null" />.</exception>
        ///// <exception cref="T:System.InvalidOperationException">
        ///// <paramref name="source" /> contains no elements.</exception>
        ///// <returns>The final accumulator value.</returns>
        //public static TSource Aggregate<TSource>(
        //  this IEnumerable<TSource> source,
        //  Func<TSource, TSource, TSource> func)
        //{
        //    //if (source == null)
        //    //    ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
        //    //if (func == null)
        //    //    ThrowHelper.ThrowArgumentNullException(ExceptionArgument.func);
        //    using (IEnumerator<TSource> enumerator = source.GetEnumerator())
        //    {
        //        //if (!enumerator.MoveNext())
        //        //    ThrowHelper.ThrowNoElementsException();
        //        TSource source1 = enumerator.Current;
        //        while (enumerator.MoveNext())
        //            source1 = func(source1, enumerator.Current);
        //        return source1;
        //    }
        //}

        ///// <summary>Applies an accumulator function over a sequence. The specified seed value is used as the initial accumulator value.</summary>
        ///// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
        ///// <param name="seed">The initial accumulator value.</param>
        ///// <param name="func">An accumulator function to be invoked on each element.</param>
        ///// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        ///// <typeparam name="TAccumulate">The type of the accumulator value.</typeparam>
        ///// <exception cref="T:System.ArgumentNullException">
        ///// <paramref name="source" /> or <paramref name="func" /> is <see langword="null" />.</exception>
        ///// <returns>The final accumulator value.</returns>
        //public static TAccumulate Aggregate<TSource, TAccumulate>(
        //  this IEnumerable<TSource> source,
        //  TAccumulate seed,
        //  Func<TAccumulate, TSource, TAccumulate> func)
        //{
        //    //if (source == null)
        //    //    ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
        //    //if (func == null)
        //    //    ThrowHelper.ThrowArgumentNullException(ExceptionArgument.func);
        //    TAccumulate accumulate = seed;
        //    foreach (TSource source1 in source)
        //        accumulate = func(accumulate, source1);
        //    return accumulate;
        //}

        /// <summary>Applies an accumulator function over a sequence. 한글 The specified seed value is used as the initial accumulator value, and the specified function is used to select the result value.</summary>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
        /// <param name="seed">The initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element.</param>
        /// <param name="resultSelector">A function to transform the final accumulator value into the result value.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <typeparam name="TAccumulate">The type of the accumulator value.</typeparam>
        /// <typeparam name="TResult">The type of the resulting value.</typeparam>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="source" /> or <paramref name="func" /> or <paramref name="resultSelector" /> is <see langword="null" />.</exception>
        /// <returns>The transformed final accumulator value.</returns>
        public static TResult Aggregate<TSource, TAccumulate, TResult>(
          this IEnumerable<TSource> source,
          TAccumulate seed,
          Func<TAccumulate, TSource, TAccumulate> func,
          Func<TAccumulate, TResult> resultSelector, 
          int test123)
        {
            //if (source == null)
            //    ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
            //if (func == null)
            //    ThrowHelper.ThrowArgumentNullException(ExceptionArgument.func);
            //if (resultSelector == null)
            //    ThrowHelper.ThrowArgumentNullException(ExceptionArgument.resultSelector);
            TAccumulate accumulate = seed;
            foreach (TSource source1 in source)
                accumulate = func(accumulate, source1);
            return resultSelector(accumulate);
        }

    }


}
