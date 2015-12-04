﻿// <copyright file="IAssemblyAnalyzer.cs" company="Nate Barbettini">
// Copyright (c) 2015 Nate Barbettini. Licensed under MIT.
// </copyright>

namespace libpolyglot
{
    using System.Collections.Generic;

    /// <summary>
    /// Analyzes an assembly and determines the most likely source language
    /// based on the available heuristics.
    /// </summary>
    public interface IAssemblyAnalyzer
    {
        /// <summary>
        /// Gets the most likely source language.
        /// </summary>
        Language DetectedLanguage { get; }

        /// <summary>
        /// Gets the entire list of heuristic results.
        /// </summary>
        IReadOnlyList<AnalysisResult> AllResults { get; }
    }
}
