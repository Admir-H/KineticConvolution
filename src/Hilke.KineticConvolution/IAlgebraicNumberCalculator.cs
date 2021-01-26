﻿using System;

namespace Hilke.KineticConvolution
{
    public interface IAlgebraicNumberCalculator<TAlgebraicNumber>
    {
        public abstract TAlgebraicNumber Add(TAlgebraicNumber left, TAlgebraicNumber right);

        public abstract TAlgebraicNumber Subtract(TAlgebraicNumber left, TAlgebraicNumber right);

        public abstract TAlgebraicNumber Multiply(TAlgebraicNumber left, TAlgebraicNumber right);

        public abstract TAlgebraicNumber Divide(TAlgebraicNumber dividend, TAlgebraicNumber divisor);
        
        public abstract TAlgebraicNumber Inverse(TAlgebraicNumber number);

        public abstract TAlgebraicNumber Opposite(TAlgebraicNumber number);

        public abstract int Sign(TAlgebraicNumber number);

        public abstract TAlgebraicNumber SquareRoot(TAlgebraicNumber number);
    }
}
