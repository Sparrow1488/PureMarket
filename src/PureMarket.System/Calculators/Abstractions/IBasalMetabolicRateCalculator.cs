﻿using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.System.Calculators.Abstractions;

public interface IBasalMetabolicRateCalculator
{
    BMR Calculate(ConsumerType consumer, Mass mass, int height, int age);
}