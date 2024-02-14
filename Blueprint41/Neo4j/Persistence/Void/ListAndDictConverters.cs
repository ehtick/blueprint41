﻿using System;
using System.Collections.Generic;
using System.Linq;

using Blueprint41.Core;
using Blueprint41.TypeConversion;

namespace Blueprint41.Neo4j.Persistence.Void
{
	#region Provider Type Registration

	public partial class Neo4jPersistenceProvider : PersistenceProvider
	{
		public static readonly List<TypeMapping> supportedTypeMappings = new List<TypeMapping>()
		{
			// primitives...
			new TypeMapping(typeof(bool), typeof(bool), "b"),
			new TypeMapping(typeof(bool?), typeof(bool?), "b"),
			new TypeMapping(typeof(sbyte), typeof(long), "i"),
			new TypeMapping(typeof(sbyte?), typeof(long?), "i"),
			new TypeMapping(typeof(short), typeof(long), "i"),
			new TypeMapping(typeof(short?), typeof(long?), "i"),
			new TypeMapping(typeof(int), typeof(long), "i"),
			new TypeMapping(typeof(int?), typeof(long?), "i"),
			new TypeMapping(typeof(long), typeof(long), "i"),
			new TypeMapping(typeof(long?), typeof(long?), "i"),
			new TypeMapping(typeof(float), typeof(double), "f"),
			new TypeMapping(typeof(float?), typeof(double?), "f"),
			new TypeMapping(typeof(double), typeof(double), "f"),
			new TypeMapping(typeof(double?), typeof(double?), "f"),
			new TypeMapping(typeof(char), typeof(string), "s"),
			new TypeMapping(typeof(char?), typeof(string), "s"),
			new TypeMapping(typeof(string), typeof(string), "s"),
			new TypeMapping(typeof(DateTime), typeof(long), "dt"),
			new TypeMapping(typeof(DateTime?), typeof(long?), "dt"),
			new TypeMapping(typeof(Guid), typeof(string), "s"),
			new TypeMapping(typeof(Guid?), typeof(string), "s"),
			new TypeMapping(typeof(decimal), typeof(long), "d"),
			new TypeMapping(typeof(decimal?), typeof(long?), "d"),
			new TypeMapping(typeof(CompressedString), typeof(byte[]), "cs"),

			// arrays...
			new TypeMapping(typeof(bool[]), typeof(List<object>), "l_b"),
            new TypeMapping(typeof(bool?[]), typeof(List<object>), "l_b"),
            new TypeMapping(typeof(sbyte[]), typeof(List<object>), "l_i"),
            new TypeMapping(typeof(sbyte?[]), typeof(List<object>), "l_i"),
            new TypeMapping(typeof(short[]), typeof(List<object>), "l_i"),
            new TypeMapping(typeof(short?[]), typeof(List<object>), "l_i"),
            new TypeMapping(typeof(int[]), typeof(List<object>), "l_i"),
            new TypeMapping(typeof(int?[]), typeof(List<object>), "l_i"),
            new TypeMapping(typeof(long[]), typeof(List<object>), "l_i"),
            new TypeMapping(typeof(long?[]), typeof(List<object>), "l_i"),
            new TypeMapping(typeof(float[]), typeof(List<object>), "l_f"),
            new TypeMapping(typeof(float?[]), typeof(List<object>), "l_f"),
            new TypeMapping(typeof(double[]), typeof(List<object>), "l_f"),
            new TypeMapping(typeof(double?[]), typeof(List<object>), "l_f"),
            new TypeMapping(typeof(char[]), typeof(List<object>), "l_s"),
            new TypeMapping(typeof(char?[]), typeof(List<object>), "l_s"),
            new TypeMapping(typeof(string[]), typeof(List<object>), "l_s"),
            new TypeMapping(typeof(DateTime[]), typeof(List<object>), "l_dt"),
            new TypeMapping(typeof(DateTime?[]), typeof(List<object>), "l_dt"),
            new TypeMapping(typeof(Guid[]), typeof(List<object>), "l_s"),
            new TypeMapping(typeof(Guid?[]), typeof(List<object>), "l_s"),
            new TypeMapping(typeof(decimal[]), typeof(List<object>), "l_d"),
            new TypeMapping(typeof(decimal?[]), typeof(List<object>), "l_d"),
            new TypeMapping(typeof(CompressedString[]), typeof(List<object>), "l_cs"),
          
			// lists...
			new TypeMapping(typeof(List<bool>), typeof(List<object>), "l_b"),
			new TypeMapping(typeof(List<bool?>), typeof(List<object>), "l_b"),
			new TypeMapping(typeof(List<sbyte>), typeof(List<object>), "l_i"),
			new TypeMapping(typeof(List<sbyte?>), typeof(List<object>), "l_i"),
			new TypeMapping(typeof(List<short>), typeof(List<object>), "l_i"),
			new TypeMapping(typeof(List<short?>), typeof(List<object>), "l_i"),
			new TypeMapping(typeof(List<int>), typeof(List<object>), "l_i"),
			new TypeMapping(typeof(List<int?>), typeof(List<object>), "l_i"),
			new TypeMapping(typeof(List<long>), typeof(List<object>), "l_i"),
			new TypeMapping(typeof(List<long?>), typeof(List<object>), "l_i"),
			new TypeMapping(typeof(List<float>), typeof(List<object>), "l_f"),
			new TypeMapping(typeof(List<float?>), typeof(List<object>), "l_f"),
			new TypeMapping(typeof(List<double>), typeof(List<object>), "l_f"),
			new TypeMapping(typeof(List<double?>), typeof(List<object>), "l_f"),
			new TypeMapping(typeof(List<char>), typeof(List<object>), "l_s"),
			new TypeMapping(typeof(List<char?>), typeof(List<object>), "l_s"),
			new TypeMapping(typeof(List<string>), typeof(List<object>), "l_s"),
			new TypeMapping(typeof(List<DateTime>), typeof(List<object>), "l_dt"),
			new TypeMapping(typeof(List<DateTime?>), typeof(List<object>), "l_dt"),
			new TypeMapping(typeof(List<Guid>), typeof(List<object>), "l_s"),
			new TypeMapping(typeof(List<Guid?>), typeof(List<object>), "l_s"),
			new TypeMapping(typeof(List<decimal>), typeof(List<object>), "l_d"),
			new TypeMapping(typeof(List<decimal?>), typeof(List<object>), "l_d"),
			new TypeMapping(typeof(List<CompressedString>), typeof(List<object>), "l_cs"),
          

			// dictionaries
			new TypeMapping(typeof(Dictionary<bool, bool>), typeof(string), "d_b_b"),
			new TypeMapping(typeof(Dictionary<bool, bool?>), typeof(string), "d_b_b"),
			new TypeMapping(typeof(Dictionary<bool, sbyte>), typeof(string), "d_b_i"),
			new TypeMapping(typeof(Dictionary<bool, sbyte?>), typeof(string), "d_b_i"),
			new TypeMapping(typeof(Dictionary<bool, short>), typeof(string), "d_b_i"),
			new TypeMapping(typeof(Dictionary<bool, short?>), typeof(string), "d_b_i"),
			new TypeMapping(typeof(Dictionary<bool, int>), typeof(string), "d_b_i"),
			new TypeMapping(typeof(Dictionary<bool, int?>), typeof(string), "d_b_i"),
			new TypeMapping(typeof(Dictionary<bool, long>), typeof(string), "d_b_i"),
			new TypeMapping(typeof(Dictionary<bool, long?>), typeof(string), "d_b_i"),
			new TypeMapping(typeof(Dictionary<bool, float>), typeof(string), "d_b_f"),
			new TypeMapping(typeof(Dictionary<bool, float?>), typeof(string), "d_b_f"),
			new TypeMapping(typeof(Dictionary<bool, double>), typeof(string), "d_b_f"),
			new TypeMapping(typeof(Dictionary<bool, double?>), typeof(string), "d_b_f"),
			new TypeMapping(typeof(Dictionary<bool, char>), typeof(string), "d_b_s"),
			new TypeMapping(typeof(Dictionary<bool, char?>), typeof(string), "d_b_s"),
			new TypeMapping(typeof(Dictionary<bool, string>), typeof(string), "d_b_s"),
			new TypeMapping(typeof(Dictionary<bool, DateTime>), typeof(string), "d_b_dt"),
			new TypeMapping(typeof(Dictionary<bool, DateTime?>), typeof(string), "d_b_dt"),
			new TypeMapping(typeof(Dictionary<bool, Guid>), typeof(string), "d_b_s"),
			new TypeMapping(typeof(Dictionary<bool, Guid?>), typeof(string), "d_b_s"),
			new TypeMapping(typeof(Dictionary<bool, decimal>), typeof(string), "d_b_d"),
			new TypeMapping(typeof(Dictionary<bool, decimal?>), typeof(string), "d_b_d"),
			new TypeMapping(typeof(Dictionary<bool, CompressedString>), typeof(string), "d_b_cs"),
			new TypeMapping(typeof(Dictionary<sbyte, bool>), typeof(string), "d_i_b"),
			new TypeMapping(typeof(Dictionary<sbyte, bool?>), typeof(string), "d_i_b"),
			new TypeMapping(typeof(Dictionary<sbyte, sbyte>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<sbyte, sbyte?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<sbyte, short>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<sbyte, short?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<sbyte, int>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<sbyte, int?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<sbyte, long>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<sbyte, long?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<sbyte, float>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<sbyte, float?>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<sbyte, double>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<sbyte, double?>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<sbyte, char>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<sbyte, char?>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<sbyte, string>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<sbyte, DateTime>), typeof(string), "d_i_dt"),
			new TypeMapping(typeof(Dictionary<sbyte, DateTime?>), typeof(string), "d_i_dt"),
			new TypeMapping(typeof(Dictionary<sbyte, Guid>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<sbyte, Guid?>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<sbyte, decimal>), typeof(string), "d_i_d"),
			new TypeMapping(typeof(Dictionary<sbyte, decimal?>), typeof(string), "d_i_d"),
			new TypeMapping(typeof(Dictionary<sbyte, CompressedString>), typeof(string), "d_i_cs"),
			new TypeMapping(typeof(Dictionary<short, bool>), typeof(string), "d_i_b"),
			new TypeMapping(typeof(Dictionary<short, bool?>), typeof(string), "d_i_b"),
			new TypeMapping(typeof(Dictionary<short, sbyte>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<short, sbyte?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<short, short>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<short, short?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<short, int>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<short, int?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<short, long>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<short, long?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<short, float>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<short, float?>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<short, double>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<short, double?>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<short, char>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<short, char?>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<short, string>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<short, DateTime>), typeof(string), "d_i_dt"),
			new TypeMapping(typeof(Dictionary<short, DateTime?>), typeof(string), "d_i_dt"),
			new TypeMapping(typeof(Dictionary<short, Guid>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<short, Guid?>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<short, decimal>), typeof(string), "d_i_d"),
			new TypeMapping(typeof(Dictionary<short, decimal?>), typeof(string), "d_i_d"),
			new TypeMapping(typeof(Dictionary<short, CompressedString>), typeof(string), "d_i_cs"),
			new TypeMapping(typeof(Dictionary<int, bool>), typeof(string), "d_i_b"),
			new TypeMapping(typeof(Dictionary<int, bool?>), typeof(string), "d_i_b"),
			new TypeMapping(typeof(Dictionary<int, sbyte>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<int, sbyte?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<int, short>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<int, short?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<int, int>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<int, int?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<int, long>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<int, long?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<int, float>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<int, float?>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<int, double>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<int, double?>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<int, char>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<int, char?>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<int, string>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<int, DateTime>), typeof(string), "d_i_dt"),
			new TypeMapping(typeof(Dictionary<int, DateTime?>), typeof(string), "d_i_dt"),
			new TypeMapping(typeof(Dictionary<int, Guid>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<int, Guid?>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<int, decimal>), typeof(string), "d_i_d"),
			new TypeMapping(typeof(Dictionary<int, decimal?>), typeof(string), "d_i_d"),
			new TypeMapping(typeof(Dictionary<int, CompressedString>), typeof(string), "d_i_cs"),
			new TypeMapping(typeof(Dictionary<long, bool>), typeof(string), "d_i_b"),
			new TypeMapping(typeof(Dictionary<long, bool?>), typeof(string), "d_i_b"),
			new TypeMapping(typeof(Dictionary<long, sbyte>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<long, sbyte?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<long, short>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<long, short?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<long, int>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<long, int?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<long, long>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<long, long?>), typeof(string), "d_i_i"),
			new TypeMapping(typeof(Dictionary<long, float>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<long, float?>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<long, double>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<long, double?>), typeof(string), "d_i_f"),
			new TypeMapping(typeof(Dictionary<long, char>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<long, char?>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<long, string>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<long, DateTime>), typeof(string), "d_i_dt"),
			new TypeMapping(typeof(Dictionary<long, DateTime?>), typeof(string), "d_i_dt"),
			new TypeMapping(typeof(Dictionary<long, Guid>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<long, Guid?>), typeof(string), "d_i_s"),
			new TypeMapping(typeof(Dictionary<long, decimal>), typeof(string), "d_i_d"),
			new TypeMapping(typeof(Dictionary<long, decimal?>), typeof(string), "d_i_d"),
			new TypeMapping(typeof(Dictionary<long, CompressedString>), typeof(string), "d_i_cs"),
			new TypeMapping(typeof(Dictionary<float, bool>), typeof(string), "d_f_b"),
			new TypeMapping(typeof(Dictionary<float, bool?>), typeof(string), "d_f_b"),
			new TypeMapping(typeof(Dictionary<float, sbyte>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<float, sbyte?>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<float, short>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<float, short?>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<float, int>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<float, int?>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<float, long>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<float, long?>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<float, float>), typeof(string), "d_f_f"),
			new TypeMapping(typeof(Dictionary<float, float?>), typeof(string), "d_f_f"),
			new TypeMapping(typeof(Dictionary<float, double>), typeof(string), "d_f_f"),
			new TypeMapping(typeof(Dictionary<float, double?>), typeof(string), "d_f_f"),
			new TypeMapping(typeof(Dictionary<float, char>), typeof(string), "d_f_s"),
			new TypeMapping(typeof(Dictionary<float, char?>), typeof(string), "d_f_s"),
			new TypeMapping(typeof(Dictionary<float, string>), typeof(string), "d_f_s"),
			new TypeMapping(typeof(Dictionary<float, DateTime>), typeof(string), "d_f_dt"),
			new TypeMapping(typeof(Dictionary<float, DateTime?>), typeof(string), "d_f_dt"),
			new TypeMapping(typeof(Dictionary<float, Guid>), typeof(string), "d_f_s"),
			new TypeMapping(typeof(Dictionary<float, Guid?>), typeof(string), "d_f_s"),
			new TypeMapping(typeof(Dictionary<float, decimal>), typeof(string), "d_f_d"),
			new TypeMapping(typeof(Dictionary<float, decimal?>), typeof(string), "d_f_d"),
			new TypeMapping(typeof(Dictionary<float, CompressedString>), typeof(string), "d_f_cs"),
			new TypeMapping(typeof(Dictionary<double, bool>), typeof(string), "d_f_b"),
			new TypeMapping(typeof(Dictionary<double, bool?>), typeof(string), "d_f_b"),
			new TypeMapping(typeof(Dictionary<double, sbyte>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<double, sbyte?>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<double, short>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<double, short?>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<double, int>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<double, int?>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<double, long>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<double, long?>), typeof(string), "d_f_i"),
			new TypeMapping(typeof(Dictionary<double, float>), typeof(string), "d_f_f"),
			new TypeMapping(typeof(Dictionary<double, float?>), typeof(string), "d_f_f"),
			new TypeMapping(typeof(Dictionary<double, double>), typeof(string), "d_f_f"),
			new TypeMapping(typeof(Dictionary<double, double?>), typeof(string), "d_f_f"),
			new TypeMapping(typeof(Dictionary<double, char>), typeof(string), "d_f_s"),
			new TypeMapping(typeof(Dictionary<double, char?>), typeof(string), "d_f_s"),
			new TypeMapping(typeof(Dictionary<double, string>), typeof(string), "d_f_s"),
			new TypeMapping(typeof(Dictionary<double, DateTime>), typeof(string), "d_f_dt"),
			new TypeMapping(typeof(Dictionary<double, DateTime?>), typeof(string), "d_f_dt"),
			new TypeMapping(typeof(Dictionary<double, Guid>), typeof(string), "d_f_s"),
			new TypeMapping(typeof(Dictionary<double, Guid?>), typeof(string), "d_f_s"),
			new TypeMapping(typeof(Dictionary<double, decimal>), typeof(string), "d_f_d"),
			new TypeMapping(typeof(Dictionary<double, decimal?>), typeof(string), "d_f_d"),
			new TypeMapping(typeof(Dictionary<double, CompressedString>), typeof(string), "d_f_cs"),
			new TypeMapping(typeof(Dictionary<char, bool>), typeof(string), "d_s_b"),
			new TypeMapping(typeof(Dictionary<char, bool?>), typeof(string), "d_s_b"),
			new TypeMapping(typeof(Dictionary<char, sbyte>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<char, sbyte?>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<char, short>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<char, short?>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<char, int>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<char, int?>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<char, long>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<char, long?>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<char, float>), typeof(string), "d_s_f"),
			new TypeMapping(typeof(Dictionary<char, float?>), typeof(string), "d_s_f"),
			new TypeMapping(typeof(Dictionary<char, double>), typeof(string), "d_s_f"),
			new TypeMapping(typeof(Dictionary<char, double?>), typeof(string), "d_s_f"),
			new TypeMapping(typeof(Dictionary<char, char>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<char, char?>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<char, string>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<char, DateTime>), typeof(string), "d_s_dt"),
			new TypeMapping(typeof(Dictionary<char, DateTime?>), typeof(string), "d_s_dt"),
			new TypeMapping(typeof(Dictionary<char, Guid>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<char, Guid?>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<char, decimal>), typeof(string), "d_s_d"),
			new TypeMapping(typeof(Dictionary<char, decimal?>), typeof(string), "d_s_d"),
			new TypeMapping(typeof(Dictionary<char, CompressedString>), typeof(string), "d_s_cs"),
			new TypeMapping(typeof(Dictionary<string, bool>), typeof(string), "d_s_b"),
			new TypeMapping(typeof(Dictionary<string, bool?>), typeof(string), "d_s_b"),
			new TypeMapping(typeof(Dictionary<string, sbyte>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<string, sbyte?>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<string, short>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<string, short?>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<string, int>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<string, int?>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<string, long>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<string, long?>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<string, float>), typeof(string), "d_s_f"),
			new TypeMapping(typeof(Dictionary<string, float?>), typeof(string), "d_s_f"),
			new TypeMapping(typeof(Dictionary<string, double>), typeof(string), "d_s_f"),
			new TypeMapping(typeof(Dictionary<string, double?>), typeof(string), "d_s_f"),
			new TypeMapping(typeof(Dictionary<string, char>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<string, char?>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<string, string>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<string, DateTime>), typeof(string), "d_s_dt"),
			new TypeMapping(typeof(Dictionary<string, DateTime?>), typeof(string), "d_s_dt"),
			new TypeMapping(typeof(Dictionary<string, Guid>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<string, Guid?>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<string, decimal>), typeof(string), "d_s_d"),
			new TypeMapping(typeof(Dictionary<string, decimal?>), typeof(string), "d_s_d"),
			new TypeMapping(typeof(Dictionary<string, CompressedString>), typeof(string), "d_s_cs"),
			new TypeMapping(typeof(Dictionary<DateTime, bool>), typeof(string), "d_dt_b"),
			new TypeMapping(typeof(Dictionary<DateTime, bool?>), typeof(string), "d_dt_b"),
			new TypeMapping(typeof(Dictionary<DateTime, sbyte>), typeof(string), "d_dt_i"),
			new TypeMapping(typeof(Dictionary<DateTime, sbyte?>), typeof(string), "d_dt_i"),
			new TypeMapping(typeof(Dictionary<DateTime, short>), typeof(string), "d_dt_i"),
			new TypeMapping(typeof(Dictionary<DateTime, short?>), typeof(string), "d_dt_i"),
			new TypeMapping(typeof(Dictionary<DateTime, int>), typeof(string), "d_dt_i"),
			new TypeMapping(typeof(Dictionary<DateTime, int?>), typeof(string), "d_dt_i"),
			new TypeMapping(typeof(Dictionary<DateTime, long>), typeof(string), "d_dt_i"),
			new TypeMapping(typeof(Dictionary<DateTime, long?>), typeof(string), "d_dt_i"),
			new TypeMapping(typeof(Dictionary<DateTime, float>), typeof(string), "d_dt_f"),
			new TypeMapping(typeof(Dictionary<DateTime, float?>), typeof(string), "d_dt_f"),
			new TypeMapping(typeof(Dictionary<DateTime, double>), typeof(string), "d_dt_f"),
			new TypeMapping(typeof(Dictionary<DateTime, double?>), typeof(string), "d_dt_f"),
			new TypeMapping(typeof(Dictionary<DateTime, char>), typeof(string), "d_dt_s"),
			new TypeMapping(typeof(Dictionary<DateTime, char?>), typeof(string), "d_dt_s"),
			new TypeMapping(typeof(Dictionary<DateTime, string>), typeof(string), "d_dt_s"),
			new TypeMapping(typeof(Dictionary<DateTime, DateTime>), typeof(string), "d_dt_dt"),
			new TypeMapping(typeof(Dictionary<DateTime, DateTime?>), typeof(string), "d_dt_dt"),
			new TypeMapping(typeof(Dictionary<DateTime, Guid>), typeof(string), "d_dt_s"),
			new TypeMapping(typeof(Dictionary<DateTime, Guid?>), typeof(string), "d_dt_s"),
			new TypeMapping(typeof(Dictionary<DateTime, decimal>), typeof(string), "d_dt_d"),
			new TypeMapping(typeof(Dictionary<DateTime, decimal?>), typeof(string), "d_dt_d"),
			new TypeMapping(typeof(Dictionary<DateTime, CompressedString>), typeof(string), "d_dt_cs"),
			new TypeMapping(typeof(Dictionary<Guid, bool>), typeof(string), "d_s_b"),
			new TypeMapping(typeof(Dictionary<Guid, bool?>), typeof(string), "d_s_b"),
			new TypeMapping(typeof(Dictionary<Guid, sbyte>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<Guid, sbyte?>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<Guid, short>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<Guid, short?>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<Guid, int>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<Guid, int?>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<Guid, long>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<Guid, long?>), typeof(string), "d_s_i"),
			new TypeMapping(typeof(Dictionary<Guid, float>), typeof(string), "d_s_f"),
			new TypeMapping(typeof(Dictionary<Guid, float?>), typeof(string), "d_s_f"),
			new TypeMapping(typeof(Dictionary<Guid, double>), typeof(string), "d_s_f"),
			new TypeMapping(typeof(Dictionary<Guid, double?>), typeof(string), "d_s_f"),
			new TypeMapping(typeof(Dictionary<Guid, char>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<Guid, char?>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<Guid, string>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<Guid, DateTime>), typeof(string), "d_s_dt"),
			new TypeMapping(typeof(Dictionary<Guid, DateTime?>), typeof(string), "d_s_dt"),
			new TypeMapping(typeof(Dictionary<Guid, Guid>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<Guid, Guid?>), typeof(string), "d_s_s"),
			new TypeMapping(typeof(Dictionary<Guid, decimal>), typeof(string), "d_s_d"),
			new TypeMapping(typeof(Dictionary<Guid, decimal?>), typeof(string), "d_s_d"),
			new TypeMapping(typeof(Dictionary<Guid, CompressedString>), typeof(string), "d_s_cs"),
			new TypeMapping(typeof(Dictionary<decimal, bool>), typeof(string), "d_d_b"),
			new TypeMapping(typeof(Dictionary<decimal, bool?>), typeof(string), "d_d_b"),
			new TypeMapping(typeof(Dictionary<decimal, sbyte>), typeof(string), "d_d_i"),
			new TypeMapping(typeof(Dictionary<decimal, sbyte?>), typeof(string), "d_d_i"),
			new TypeMapping(typeof(Dictionary<decimal, short>), typeof(string), "d_d_i"),
			new TypeMapping(typeof(Dictionary<decimal, short?>), typeof(string), "d_d_i"),
			new TypeMapping(typeof(Dictionary<decimal, int>), typeof(string), "d_d_i"),
			new TypeMapping(typeof(Dictionary<decimal, int?>), typeof(string), "d_d_i"),
			new TypeMapping(typeof(Dictionary<decimal, long>), typeof(string), "d_d_i"),
			new TypeMapping(typeof(Dictionary<decimal, long?>), typeof(string), "d_d_i"),
			new TypeMapping(typeof(Dictionary<decimal, float>), typeof(string), "d_d_f"),
			new TypeMapping(typeof(Dictionary<decimal, float?>), typeof(string), "d_d_f"),
			new TypeMapping(typeof(Dictionary<decimal, double>), typeof(string), "d_d_f"),
			new TypeMapping(typeof(Dictionary<decimal, double?>), typeof(string), "d_d_f"),
			new TypeMapping(typeof(Dictionary<decimal, char>), typeof(string), "d_d_s"),
			new TypeMapping(typeof(Dictionary<decimal, char?>), typeof(string), "d_d_s"),
			new TypeMapping(typeof(Dictionary<decimal, string>), typeof(string), "d_d_s"),
			new TypeMapping(typeof(Dictionary<decimal, DateTime>), typeof(string), "d_d_dt"),
			new TypeMapping(typeof(Dictionary<decimal, DateTime?>), typeof(string), "d_d_dt"),
			new TypeMapping(typeof(Dictionary<decimal, Guid>), typeof(string), "d_d_s"),
			new TypeMapping(typeof(Dictionary<decimal, Guid?>), typeof(string), "d_d_s"),
			new TypeMapping(typeof(Dictionary<decimal, decimal>), typeof(string), "d_d_d"),
			new TypeMapping(typeof(Dictionary<decimal, decimal?>), typeof(string), "d_d_d"),
			new TypeMapping(typeof(Dictionary<decimal, CompressedString>), typeof(string), "d_d_cs"),
			new TypeMapping(typeof(Dictionary<CompressedString, bool>), typeof(string), "d_cs_b"),
			new TypeMapping(typeof(Dictionary<CompressedString, bool?>), typeof(string), "d_cs_b"),
			new TypeMapping(typeof(Dictionary<CompressedString, sbyte>), typeof(string), "d_cs_i"),
			new TypeMapping(typeof(Dictionary<CompressedString, sbyte?>), typeof(string), "d_cs_i"),
			new TypeMapping(typeof(Dictionary<CompressedString, short>), typeof(string), "d_cs_i"),
			new TypeMapping(typeof(Dictionary<CompressedString, short?>), typeof(string), "d_cs_i"),
			new TypeMapping(typeof(Dictionary<CompressedString, int>), typeof(string), "d_cs_i"),
			new TypeMapping(typeof(Dictionary<CompressedString, int?>), typeof(string), "d_cs_i"),
			new TypeMapping(typeof(Dictionary<CompressedString, long>), typeof(string), "d_cs_i"),
			new TypeMapping(typeof(Dictionary<CompressedString, long?>), typeof(string), "d_cs_i"),
			new TypeMapping(typeof(Dictionary<CompressedString, float>), typeof(string), "d_cs_f"),
			new TypeMapping(typeof(Dictionary<CompressedString, float?>), typeof(string), "d_cs_f"),
			new TypeMapping(typeof(Dictionary<CompressedString, double>), typeof(string), "d_cs_f"),
			new TypeMapping(typeof(Dictionary<CompressedString, double?>), typeof(string), "d_cs_f"),
			new TypeMapping(typeof(Dictionary<CompressedString, char>), typeof(string), "d_cs_s"),
			new TypeMapping(typeof(Dictionary<CompressedString, char?>), typeof(string), "d_cs_s"),
			new TypeMapping(typeof(Dictionary<CompressedString, string>), typeof(string), "d_cs_s"),
			new TypeMapping(typeof(Dictionary<CompressedString, DateTime>), typeof(string), "d_cs_dt"),
			new TypeMapping(typeof(Dictionary<CompressedString, DateTime?>), typeof(string), "d_cs_dt"),
			new TypeMapping(typeof(Dictionary<CompressedString, Guid>), typeof(string), "d_cs_s"),
			new TypeMapping(typeof(Dictionary<CompressedString, Guid?>), typeof(string), "d_cs_s"),
			new TypeMapping(typeof(Dictionary<CompressedString, decimal>), typeof(string), "d_cs_d"),
			new TypeMapping(typeof(Dictionary<CompressedString, decimal?>), typeof(string), "d_cs_d"),
			new TypeMapping(typeof(Dictionary<CompressedString, CompressedString>), typeof(string), "d_cs_cs"),
           
		};
	}

	#endregion
}

