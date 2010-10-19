namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MissingResourceException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MissingResourceException()
		{
			InitJNI();
		}
		protected MissingResourceException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Key
		{
			get
			{
				return getKey();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKey20578;
		public virtual global::java.lang.String getKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.MissingResourceException._getKey20578)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.MissingResourceException.staticClass, global::java.util.MissingResourceException._getKey20578)) as java.lang.String;
		}
		public new global::java.lang.String ClassName
		{
			get
			{
				return getClassName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassName20579;
		public virtual global::java.lang.String getClassName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.MissingResourceException._getClassName20579)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.MissingResourceException.staticClass, global::java.util.MissingResourceException._getClassName20579)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _MissingResourceException20580;
		public MissingResourceException(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.MissingResourceException.staticClass, global::java.util.MissingResourceException._MissingResourceException20580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.MissingResourceException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/MissingResourceException"));
			global::java.util.MissingResourceException._getKey20578 = @__env.GetMethodIDNoThrow(global::java.util.MissingResourceException.staticClass, "getKey", "()Ljava/lang/String;");
			global::java.util.MissingResourceException._getClassName20579 = @__env.GetMethodIDNoThrow(global::java.util.MissingResourceException.staticClass, "getClassName", "()Ljava/lang/String;");
			global::java.util.MissingResourceException._MissingResourceException20580 = @__env.GetMethodIDNoThrow(global::java.util.MissingResourceException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
