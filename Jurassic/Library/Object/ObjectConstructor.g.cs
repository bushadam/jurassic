/*
 * This file is auto-generated, do not modify directly.
 */

using System.Collections.Generic;
using Jurassic;

namespace Jurassic.Library
{

	public partial class ObjectConstructor
	{
		internal new List<PropertyNameAndValue> GetDeclarativeProperties()
		{
			return new List<PropertyNameAndValue>(17)
			{
				new PropertyNameAndValue("getPrototypeOf", new ClrStubFunction(this.Engine.Function.InstancePrototype, "getPrototypeOf", 1, __STUB__getPrototypeOf), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("getOwnPropertyDescriptor", new ClrStubFunction(this.Engine.Function.InstancePrototype, "getOwnPropertyDescriptor", 2, __STUB__getOwnPropertyDescriptor), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("getOwnPropertyNames", new ClrStubFunction(this.Engine.Function.InstancePrototype, "getOwnPropertyNames", 1, __STUB__getOwnPropertyNames), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("create", new ClrStubFunction(this.Engine.Function.InstancePrototype, "create", 2, __STUB__create), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("defineProperty", new ClrStubFunction(this.Engine.Function.InstancePrototype, "defineProperty", 3, __STUB__defineProperty), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("defineProperties", new ClrStubFunction(this.Engine.Function.InstancePrototype, "defineProperties", 2, __STUB__defineProperties), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("seal", new ClrStubFunction(this.Engine.Function.InstancePrototype, "seal", 1, __STUB__seal), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("freeze", new ClrStubFunction(this.Engine.Function.InstancePrototype, "freeze", 1, __STUB__freeze), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("preventExtensions", new ClrStubFunction(this.Engine.Function.InstancePrototype, "preventExtensions", 1, __STUB__preventExtensions), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("isSealed", new ClrStubFunction(this.Engine.Function.InstancePrototype, "isSealed", 1, __STUB__isSealed), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("isFrozen", new ClrStubFunction(this.Engine.Function.InstancePrototype, "isFrozen", 1, __STUB__isFrozen), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("isExtensible", new ClrStubFunction(this.Engine.Function.InstancePrototype, "isExtensible", 1, __STUB__isExtensible), PropertyAttributes.NonEnumerable),
				new PropertyNameAndValue("keys", new ClrStubFunction(this.Engine.Function.InstancePrototype, "keys", 1, __STUB__keys), PropertyAttributes.NonEnumerable),
			};
		}

		private static object __STUB__Call(ScriptEngine engine, object thisObj, object[] args)
		{
			thisObj = TypeConverter.ToObject(engine, thisObj);
			if (!(thisObj is ObjectConstructor))
				throw new JavaScriptException(engine, "TypeError", "The method 'Call' is not generic.");
			switch (args.Length)
			{
				case 0:
					return ((ObjectConstructor)thisObj).Call(Undefined.Value);
				default:
					return ((ObjectConstructor)thisObj).Call(args[0]);
			}
		}

		private static ObjectInstance __STUB__Construct(ScriptEngine engine, object thisObj, object[] args)
		{
			thisObj = TypeConverter.ToObject(engine, thisObj);
			if (!(thisObj is ObjectConstructor))
				throw new JavaScriptException(engine, "TypeError", "The method 'Construct' is not generic.");
			switch (args.Length)
			{
				case 0:
					return ((ObjectConstructor)thisObj).Construct();
				default:
					return ((ObjectConstructor)thisObj).Construct(args[0]);
			}
		}

		private static object __STUB__getPrototypeOf(ScriptEngine engine, object thisObj, object[] args)
		{
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, "TypeError", "undefined cannot be converted to an object");
				default:
					return GetPrototypeOf(TypeConverter.ToObject(engine, args[0]));
			}
		}

		private static object __STUB__getOwnPropertyDescriptor(ScriptEngine engine, object thisObj, object[] args)
		{
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, "TypeError", "undefined cannot be converted to an object");
				case 1:
					return GetOwnPropertyDescriptor(TypeConverter.ToObject(engine, args[0]), "undefined");
				default:
					return GetOwnPropertyDescriptor(TypeConverter.ToObject(engine, args[0]), TypeConverter.ToString(args[1]));
			}
		}

		private static object __STUB__getOwnPropertyNames(ScriptEngine engine, object thisObj, object[] args)
		{
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, "TypeError", "undefined cannot be converted to an object");
				default:
					return GetOwnPropertyNames(TypeConverter.ToObject(engine, args[0]));
			}
		}

		private static object __STUB__create(ScriptEngine engine, object thisObj, object[] args)
		{
			switch (args.Length)
			{
				case 0:
					return Create(engine, Undefined.Value, null);
				case 1:
					return Create(engine, args[0], null);
				default:
					return Create(engine, args[0], TypeConverter.ToObject(engine, args[1], null));
			}
		}

		private static object __STUB__defineProperty(ScriptEngine engine, object thisObj, object[] args)
		{
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, "TypeError", "undefined cannot be converted to an object");
				case 1:
					return DefineProperty(TypeConverter.ToObject(engine, args[0]), "undefined", Undefined.Value);
				case 2:
					return DefineProperty(TypeConverter.ToObject(engine, args[0]), TypeConverter.ToString(args[1]), Undefined.Value);
				default:
					return DefineProperty(TypeConverter.ToObject(engine, args[0]), TypeConverter.ToString(args[1]), args[2]);
			}
		}

		private static object __STUB__defineProperties(ScriptEngine engine, object thisObj, object[] args)
		{
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, "TypeError", "undefined cannot be converted to an object");
				case 1:
					throw new JavaScriptException(engine, "TypeError", "undefined cannot be converted to an object");
				default:
					return DefineProperties(args[0], TypeConverter.ToObject(engine, args[1]));
			}
		}

		private static object __STUB__seal(ScriptEngine engine, object thisObj, object[] args)
		{
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, "TypeError", "undefined cannot be converted to an object");
				default:
					return Seal(TypeConverter.ToObject(engine, args[0]));
			}
		}

		private static object __STUB__freeze(ScriptEngine engine, object thisObj, object[] args)
		{
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, "TypeError", "undefined cannot be converted to an object");
				default:
					return Freeze(TypeConverter.ToObject(engine, args[0]));
			}
		}

		private static object __STUB__preventExtensions(ScriptEngine engine, object thisObj, object[] args)
		{
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, "TypeError", "undefined cannot be converted to an object");
				default:
					return PreventExtensions(TypeConverter.ToObject(engine, args[0]));
			}
		}

		private static object __STUB__isSealed(ScriptEngine engine, object thisObj, object[] args)
		{
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, "TypeError", "undefined cannot be converted to an object");
				default:
					return IsSealed(TypeConverter.ToObject(engine, args[0]));
			}
		}

		private static object __STUB__isFrozen(ScriptEngine engine, object thisObj, object[] args)
		{
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, "TypeError", "undefined cannot be converted to an object");
				default:
					return IsFrozen(TypeConverter.ToObject(engine, args[0]));
			}
		}

		private static object __STUB__isExtensible(ScriptEngine engine, object thisObj, object[] args)
		{
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, "TypeError", "undefined cannot be converted to an object");
				default:
					return IsExtensible(TypeConverter.ToObject(engine, args[0]));
			}
		}

		private static object __STUB__keys(ScriptEngine engine, object thisObj, object[] args)
		{
			switch (args.Length)
			{
				case 0:
					throw new JavaScriptException(engine, "TypeError", "undefined cannot be converted to an object");
				default:
					return Keys(TypeConverter.ToObject(engine, args[0]));
			}
		}
	}

}