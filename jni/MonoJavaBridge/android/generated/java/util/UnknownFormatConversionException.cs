namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnknownFormatConversionException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnknownFormatConversionException()
		{
			InitJNI();
		}
		protected UnknownFormatConversionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage21008;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.UnknownFormatConversionException._getMessage21008)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.UnknownFormatConversionException.staticClass, global::java.util.UnknownFormatConversionException._getMessage21008)) as java.lang.String;
		}
		public new global::java.lang.String Conversion
		{
			get
			{
				return getConversion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConversion21009;
		public virtual global::java.lang.String getConversion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.UnknownFormatConversionException._getConversion21009)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.UnknownFormatConversionException.staticClass, global::java.util.UnknownFormatConversionException._getConversion21009)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _UnknownFormatConversionException21010;
		public UnknownFormatConversionException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.UnknownFormatConversionException.staticClass, global::java.util.UnknownFormatConversionException._UnknownFormatConversionException21010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.UnknownFormatConversionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/UnknownFormatConversionException"));
			global::java.util.UnknownFormatConversionException._getMessage21008 = @__env.GetMethodIDNoThrow(global::java.util.UnknownFormatConversionException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.UnknownFormatConversionException._getConversion21009 = @__env.GetMethodIDNoThrow(global::java.util.UnknownFormatConversionException.staticClass, "getConversion", "()Ljava/lang/String;");
			global::java.util.UnknownFormatConversionException._UnknownFormatConversionException21010 = @__env.GetMethodIDNoThrow(global::java.util.UnknownFormatConversionException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
