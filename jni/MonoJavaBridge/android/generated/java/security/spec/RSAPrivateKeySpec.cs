namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RSAPrivateKeySpec : java.lang.Object, KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RSAPrivateKeySpec()
		{
			InitJNI();
		}
		protected RSAPrivateKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.math.BigInteger Modulus
		{
			get
			{
				return getModulus();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModulus18343;
		public virtual global::java.math.BigInteger getModulus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateKeySpec._getModulus18343)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateKeySpec.staticClass, global::java.security.spec.RSAPrivateKeySpec._getModulus18343)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger PrivateExponent
		{
			get
			{
				return getPrivateExponent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateExponent18344;
		public virtual global::java.math.BigInteger getPrivateExponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateKeySpec._getPrivateExponent18344)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.RSAPrivateKeySpec.staticClass, global::java.security.spec.RSAPrivateKeySpec._getPrivateExponent18344)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _RSAPrivateKeySpec18345;
		public RSAPrivateKeySpec(java.math.BigInteger arg0, java.math.BigInteger arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.RSAPrivateKeySpec.staticClass, global::java.security.spec.RSAPrivateKeySpec._RSAPrivateKeySpec18345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.RSAPrivateKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/RSAPrivateKeySpec"));
			global::java.security.spec.RSAPrivateKeySpec._getModulus18343 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPrivateKeySpec.staticClass, "getModulus", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAPrivateKeySpec._getPrivateExponent18344 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPrivateKeySpec.staticClass, "getPrivateExponent", "()Ljava/math/BigInteger;");
			global::java.security.spec.RSAPrivateKeySpec._RSAPrivateKeySpec18345 = @__env.GetMethodIDNoThrow(global::java.security.spec.RSAPrivateKeySpec.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
		}
	}
}
