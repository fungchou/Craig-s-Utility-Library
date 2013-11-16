// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.IoC.Default.DefaultBootstrapper.#Resolve(System.Type,System.String,System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.IO.FileSystem.Module.FileSystemModule.#Load(Utilities.IoC.Interfaces.IBootstrapper)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1057:StringUriOverloadsCallSystemUriOverloads", Scope = "member", Target = "Utilities.IO.FileSystem.Default.WebDirectory.#.ctor(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1057:StringUriOverloadsCallSystemUriOverloads", Scope = "member", Target = "Utilities.IO.FileSystem.Default.WebFile.#.ctor(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.IO.Logging.Default.DefaultLogger.#AddLog(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.IO.Logging.Module.LoggingModule.#Load(Utilities.IoC.Interfaces.IBootstrapper)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1043:UseIntegralOrStringArgumentForIndexers", Scope = "member", Target = "Utilities.IO.Messaging.Manager.#Item[System.Type]")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.IO.Messaging.Default.SMTPSystem.#InternalSend(Utilities.IO.Messaging.Interfaces.IMessage)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.CodeGen.BaseClasses.CompilerBase.#Add(System.String,System.String,System.Collections.Generic.IEnumerable`1<System.String>,System.Reflection.Assembly[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.DataTypes.CodeGen.Module.CompilerModule.#Load(Utilities.IoC.Interfaces.IBootstrapper)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.Conversion.Converters.ExpandoTypeConverter.#ConvertTo(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,System.Object,System.Type)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.Conversion.Converters.ExpandoTypeConverter.#ConvertFrom(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.IEnumerableExtensions.#ForEach`1(System.Collections.Generic.IEnumerable`1<!!0>,System.Action`1<!!0>,System.Action`2<!!0,System.Exception>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "Utilities.DataTypes.Conversion.Converters.DbTypeTypeConverter.#TypeToDbType(System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.IEnumerableExtensions.#ForEachParallel`1(System.Collections.Generic.IEnumerable`1<!!0>,System.Action`1<!!0>,System.Action`2<!!0,System.Exception>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.IEnumerableExtensions.#ForEachParallel`2(System.Collections.Generic.IEnumerable`1<!!0>,System.Func`2<!!0,!!1>,System.Action`2<!!0,System.Exception>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Utilities.DataTypes.IEnumerableExtensions.#ToList`2(System.Collections.Generic.IEnumerable`1<!!0>,System.Func`2<!!0,!!1>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "Utilities.DataTypes.AOP.Manager.#Setup(System.Type)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Utilities.DataTypes.ReflectionExtensions.#PropertySetter`2(System.Linq.Expressions.Expression`1<System.Func`2<!!0,!!1>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.IEnumerableExtensions.#ForEach`2(System.Collections.Generic.IEnumerable`1<!!0>,System.Func`2<!!0,!!1>,System.Action`2<!!0,System.Exception>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1053:StaticHolderTypesShouldNotHaveConstructors", Scope = "type", Target = "Utilities.DataTypes.Conversion.Manager")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.Conversion.Manager.#To`1(!!0,System.Type,System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.ReflectionExtensions.#Types(System.Reflection.Assembly,System.Type)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Utilities.DataTypes.TypeConversionExtensions.#To`1(System.Data.DataTable,System.Func`1<!!0>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Utilities.IO.FileFormats.VCalendar.#GetText()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Scope = "member", Target = "Utilities.IO.FileFormats.Excel.#Parse(System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Utilities.IO.CompressionExtensions.#Compress(System.Byte[],Utilities.IO.CompressionType)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Utilities.IO.CompressionExtensions.#Decompress(System.Byte[],Utilities.IO.CompressionType)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Utilities.IO.Compression.BaseClasses.CompressorBase.#Compress(System.Byte[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Utilities.IO.Compression.BaseClasses.CompressorBase.#Decompress(System.Byte[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Utilities.IO.Encryption.BaseClasses.SymmetricBase.#Decrypt(System.Byte[],System.Security.Cryptography.DeriveBytes,System.String,System.String,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Utilities.IO.Encryption.BaseClasses.SymmetricBase.#Encrypt(System.Byte[],System.Security.Cryptography.DeriveBytes,System.String,System.String,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "Utilities.IO.Encryption.Default.Hash.#.ctor()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "Random", Scope = "member", Target = "Utilities.IO.EncryptionExtensions.#CreateKey(System.Random,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "Random", Scope = "member", Target = "Utilities.IO.EncryptionExtensions.#GenerateSalt(System.Random,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Utilities.IO.Encryption.BaseClasses.AsymmetricBase.#GetProvider()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Utilities.DataTypes.Vector3.#Array")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Utilities.IO.FileFormats.VCalendar.#GetHCalendar()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Utilities.IO.FileFormats.VCalendar.#GetICalendar()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Utilities.IO.FileFormats.VCalendar.#GetVCalendar()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "ObjectType", Scope = "member", Target = "Utilities.DataTypes.TypeConversionExtensions.#MapTo`2(System.Type)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "Object", Scope = "member", Target = "Utilities.DataTypes.TypeConversionExtensions.#MapTo`2(!!0)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.TaskQueue`1.#Process()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.TagDictionary`2.#TryGetValue(!0,System.Collections.Generic.IEnumerable`1<!1>&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Utilities.DataTypes.Row.#ColumnValues")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Utilities.DataTypes.Row.#ColumnNames")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Utilities.DataTypes.Table.#ColumnNames")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase", Scope = "member", Target = "Utilities.DataTypes.StringTemplate.#GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1814:PreferJaggedArraysOverMultidimensional", MessageId = "Body", Scope = "member", Target = "Utilities.DataTypes.StringExtensions.#LevenshteinDistance(System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1053:StaticHolderTypesShouldNotHaveConstructors", Scope = "type", Target = "Utilities.DataTypes.Patterns.BaseClasses.Singleton`1")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Utilities.DataTypes.Set`1.#op_Inequality(Utilities.DataTypes.Set`1<!0>,Utilities.DataTypes.Set`1<!0>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Utilities.DataTypes.Set`1.#op_Equality(Utilities.DataTypes.Set`1<!0>,Utilities.DataTypes.Set`1<!0>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Utilities.DataTypes.Set`1.#op_Subtraction(Utilities.DataTypes.Set`1<!0>,Utilities.DataTypes.Set`1<!0>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Utilities.DataTypes.Set`1.#op_Addition(Utilities.DataTypes.Set`1<!0>,Utilities.DataTypes.Set`1<!0>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Utilities.DataTypes.Set`1.#GetIntersection(Utilities.DataTypes.Set`1<!0>,Utilities.DataTypes.Set`1<!0>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Utilities.DataTypes.Set`1.#Intersect(Utilities.DataTypes.Set`1<!0>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Utilities.DataTypes.Set`1.#Contains(Utilities.DataTypes.Set`1<!0>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Utilities.DataTypes.Set`1.#IsSubset(Utilities.DataTypes.Set`1<!0>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Utilities.DataTypes.RingBuffer`1.#Buffer")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.ReflectionExtensions.#ToString(System.Type,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.ReflectionExtensions.#ToString(System.Object,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.ReflectionExtensions.#MakeShallowCopy`1(!!0,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1814:PreferJaggedArraysOverMultidimensional", MessageId = "Member", Scope = "member", Target = "Utilities.DataTypes.Matrix.#Values")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Utilities.DataTypes.Matrix.#Values")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1814:PreferJaggedArraysOverMultidimensional", MessageId = "Body", Scope = "member", Target = "Utilities.DataTypes.Matrix.#Height")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1814:PreferJaggedArraysOverMultidimensional", MessageId = "Body", Scope = "member", Target = "Utilities.DataTypes.Matrix.#Width")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Utilities.DataTypes.Patterns.IFluentInterface.#GetType()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1309:UseOrdinalStringComparison", MessageId = "System.String.StartsWith(System.String,System.StringComparison)", Scope = "member", Target = "Utilities.IO.HTMLExtensions.#JavaScriptMinify(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.GenericObjectExtensions.#Execute(System.Action,System.Int32,System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.GenericObjectExtensions.#Execute`1(System.Func`1<!!0>,System.Int32,System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.ExceptionExtensions.#ToString(System.Exception,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.IO.FileFormats.Delimited.Delimited.#ToDataTable(System.Boolean,System.String[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "Date", Scope = "member", Target = "Utilities.DataTypes.DateTimeExtensions.#LocalTimeZone(System.DateTime)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.DataTypes.TaskQueue`1.#.ctor(System.Int32,System.Action`1<!0>,System.Action`1<System.Exception>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "type", Target = "Utilities.DataTypes.Caching.Default.Cache")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "member", Target = "Utilities.DataTypes.Caching.Default.Cache.#Dispose()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Scope = "member", Target = "Utilities.DataTypes.Caching.Default.Cache.#Dispose()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.DataTypes.Caching.Module.CachingModule.#Load(Utilities.IoC.Interfaces.IBootstrapper)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.Configuration.Module.ConfigSystemModule.#Load(Utilities.IoC.Interfaces.IBootstrapper)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.Configuration.Manager.Module.ConfigSystemModule.#Load(Utilities.IoC.Interfaces.IBootstrapper)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Utilities.Configuration.Manager.Default.SystemConfig.#Item[System.String]")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase", Scope = "member", Target = "Utilities.DataTypes.Dynamo.#GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2240:ImplementISerializableCorrectly", Scope = "type", Target = "Utilities.Configuration.Manager.BaseClasses.Config`1")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.Profiler.Manager.Module.ProfilerModule.#Load(Utilities.IoC.Interfaces.IBootstrapper)")]
