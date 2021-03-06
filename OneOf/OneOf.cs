﻿// <auto-generated/>

namespace RetailRocket.OneOf
{
    using System;

    public class OneOf<T1, T2>
    {
        private readonly Action<
            Action<T1>,
            Action<T2>> matcher;

        public OneOf(
            T1 t1)
        {
            this.matcher = (
                func1,
                func2) => func1(t1);
        }

        public OneOf(
            T2 t2)
        {
            this.matcher = (
                func1,
                func2) => func2(t2);
        }

        public TResult Match<TResult>(
            Func<T1, TResult> case1,
            Func<T2, TResult> case2)
        {
            TResult result = default;
            this.matcher(
                v => result = case1(v),
                v => result = case2(v));
            return result;
        }

        public static implicit operator OneOf<T1, T2>(
            T1 t1)
        {
            return new OneOf<T1, T2>(t1);
        }

        public static implicit operator OneOf<T1, T2>(
            T2 t2)
        {
            return new OneOf<T1, T2>(t2);
        }

        public override bool Equals(
            object obj)
        {
            return obj is OneOf<T1, T2> otherOneOf && Equals(otherOneOf);
        }

        public override int GetHashCode()
        {
            return this.Match(
                v => v.GetHashCode(),
                v => v.GetHashCode());
        }

        public bool Equals(
            OneOf<T1, T2> otherOneOf)
        {
            return Match(
                v => otherOneOf.Match(ov => ov.Equals(v), _ => false),
                v => otherOneOf.Match(_ => false, ov => v.Equals(ov)));
        }
    }

    public class OneOf<T1, T2, T3>
    {
        private readonly Action<
            Action<T1>,
            Action<T2>,
            Action<T3>> matcher;

        protected OneOf(
            T1 t1)
        {
            this.matcher = (
                func1,
                func2,
                func3) => func1(t1);
        }

        protected OneOf(
            T2 t2)
        {
            this.matcher = (
                func1,
                func2,
                func3) => func2(t2);
        }

        protected OneOf(
            T3 t3)
        {
            this.matcher = (
                func1,
                func2,
                func3) => func3(t3);
        }

        public TResult Match<TResult>(
            Func<T1, TResult> case1,
            Func<T2, TResult> case2,
            Func<T3, TResult> case3)
        {
            TResult result = default;
            this.matcher(
                v => result = case1(v),
                v => result = case2(v),
                v => result = case3(v));
            return result;
        }

        public bool Equals(
            OneOf<T1, T2, T3> otherOneOf)
        {
            return Match(
                v => otherOneOf.Match(ov => ov.Equals(v), _ => false, _ => false),
                v => otherOneOf.Match(_ => false, ov => v.Equals(ov), _ => false),
                v => otherOneOf.Match(_ => false, _ => false, ov => v.Equals(ov)));
        }

        public static implicit operator OneOf<T1, T2, T3>(
            T1 t1)
        {
            return new OneOf<T1, T2, T3>(t1);
        }

        public static implicit operator OneOf<T1, T2, T3>(
            T2 t2)
        {
            return new OneOf<T1, T2, T3>(t2);
        }

        public static implicit operator OneOf<T1, T2, T3>(
            T3 t3)
        {
            return new OneOf<T1, T2, T3>(t3);
        }
    }

    public class OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        private readonly Action<
            Action<T1>,
            Action<T2>,
            Action<T3>,
            Action<T4>,
            Action<T5>,
            Action<T6>,
            Action<T7>,
            Action<T8>,
            Action<T9>> matcher;

        protected OneOf(
            T1 t1)
        {
            this.matcher = (
                func1,
                func2,
                func3,
                func4,
                func5,
                func6,
                func7,
                func8,
                func9) => func1(t1);
        }

        protected OneOf(
            T2 t2)
        {
            this.matcher = (
                func1,
                func2,
                func3,
                func4,
                func5,
                func6,
                func7,
                func8,
                func9) => func2(t2);
        }

        protected OneOf(
            T3 t3)
        {
            this.matcher = (
                func1,
                func2,
                func3,
                func4,
                func5,
                func6,
                func7,
                func8,
                func9) => func3(t3);
        }

        protected OneOf(
            T4 t4)
        {
            this.matcher = (
                func1,
                func2,
                func3,
                func4,
                func5,
                func6,
                func7,
                func8,
                func9) => func4(t4);
        }

        protected OneOf(
            T5 t5)
        {
            this.matcher = (
                func1,
                func2,
                func3,
                func4,
                func5,
                func6,
                func7,
                func8,
                func9) => func5(t5);
        }

        protected OneOf(
            T6 t6)
        {
            this.matcher = (
                func1,
                func2,
                func3,
                func4,
                func5,
                func6,
                func7,
                func8,
                func9) => func6(t6);
        }

        protected OneOf(
            T7 t7)
        {
            this.matcher = (
                func1,
                func2,
                func3,
                func4,
                func5,
                func6,
                func7,
                func8,
                func9) => func7(t7);
        }

        protected OneOf(
            T8 t8)
        {
            this.matcher = (
                func1,
                func2,
                func3,
                func4,
                func5,
                func6,
                func7,
                func8,
                func9) => func8(t8);
        }

        protected OneOf(
            T9 t9)
        {
            this.matcher = (
                func1,
                func2,
                func3,
                func4,
                func5,
                func6,
                func7,
                func8,
                func9) => func9(t9);
        }

        public TResult Match<TResult>(
            Func<T1, TResult> case1,
            Func<T2, TResult> case2,
            Func<T3, TResult> case3,
            Func<T4, TResult> case4,
            Func<T5, TResult> case5,
            Func<T6, TResult> case6,
            Func<T7, TResult> case7,
            Func<T8, TResult> case8,
            Func<T9, TResult> case9)
        {
            TResult result = default;
            this.matcher(
                arg1: v => result = case1(v),
                arg2: v => result = case2(v),
                arg3: v => result = case3(v),
                arg4: v => result = case4(v),
                arg5: v => result = case5(v),
                arg6: v => result = case6(v),
                arg7: v => result = case7(v),
                arg8: v => result = case8(v),
                arg9: v => result = case9(v));
            return result;
        }

        public override bool Equals(
            object obj)
        {
            return obj is OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> otherOneOf && Equals(otherOneOf);
        }

        public override int GetHashCode()
        {
            return Match(
                v => v.GetHashCode(),
                v => v.GetHashCode(),
                v => v.GetHashCode(),
                v => v.GetHashCode(),
                v => v.GetHashCode(),
                v => v.GetHashCode(),
                v => v.GetHashCode(),
                v => v.GetHashCode(),
                v => v.GetHashCode());
        }

        public bool Equals(
            OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> otherOneOf)
        {
            return Match(
                v => otherOneOf.Match(
                    ov => ov.Equals(v), _ => false, _ => false, _ => false, _ => false, _ => false, _ => false, _ => false, _ => false),
                v => otherOneOf.Match(
                    _ => false, ov => v.Equals(ov), _ => false, _ => false, _ => false, _ => false, _ => false, _ => false, _ => false),
                v => otherOneOf.Match(
                    _ => false, _ => false, ov => v.Equals(ov), _ => false, _ => false, _ => false, _ => false, _ => false, _ => false),
                v => otherOneOf.Match(
                    _ => false, _ => false, _ => false, ov => v.Equals(ov), _ => false, _ => false, _ => false, _ => false, _ => false),
                v => otherOneOf.Match(
                    _ => false, _ => false, _ => false, _ => false, ov => v.Equals(ov), _ => false, _ => false, _ => false, _ => false),
                v => otherOneOf.Match(
                    _ => false, _ => false, _ => false, _ => false, _ => false, ov => v.Equals(ov), _ => false, _ => false, _ => false),
                v => otherOneOf.Match(
                    _ => false, _ => false, _ => false, _ => false, _ => false, _ => false, ov => v.Equals(ov), _ => false, _ => false),
                v => otherOneOf.Match(
                    _ => false, _ => false, _ => false, _ => false, _ => false, _ => false, _ => false, ov => v.Equals(ov), _ => false),
                v => otherOneOf.Match(
                    _ => false, _ => false, _ => false, _ => false, _ => false, _ => false, _ => false, _ => false, ov => v.Equals(ov)));
        }

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            T1 t1)
        {
            return new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(t1);
        }

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            T2 t2)
        {
            return new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(t2);
        }

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            T3 t3)
        {
            return new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(t3);
        }

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            T4 t4)
        {
            return new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(t4);
        }

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            T5 t5)
        {
            return new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(t5);
        }

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            T6 t6)
        {
            return new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(t6);
        }

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            T7 t7)
        {
            return new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(t7);
        }

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            T8 t8)
        {
            return new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(t8);
        }

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            T9 t9)
        {
            return new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(t9);
        }
    }
}