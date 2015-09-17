namespace CompressionStockings
{
    public interface IPump
    {
        void Forward();
        void Reverse();
        void Stop();
    }
}