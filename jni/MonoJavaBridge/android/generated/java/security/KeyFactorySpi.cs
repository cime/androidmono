namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.KeyFactorySpi_))]
	public abstract partial class KeyFactorySpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyFactorySpi()
		{
			InitJNI();
		}
		protected KeyFactorySpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGeneratePublic17306;
		protected abstract global::java.security.PublicKey engineGeneratePublic(java.security.spec.KeySpec arg0);
		internal static global::MonoJavaBridge.MethodId _engineGeneratePrivate17307;
		protected abstract global::java.security.PrivateKey engineGeneratePrivate(java.security.spec.KeySpec arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetKeySpec17308;
		protected abstract global::java.security.spec.KeySpec engineGetKeySpec(java.security.Key arg0, java.lang.Class arg1);
		internal static global::MonoJavaBridge.MethodId _engineTranslateKey17309;
		protected abstract global::java.security.Key engineTranslateKey(java.security.Key arg0);
		internal static global::MonoJavaBridge.MethodId _KeyFactorySpi17310;
		public KeyFactorySpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyFactorySpi.staticClass, global::java.security.KeyFactorySpi._KeyFactorySpi17310);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyFactorySpi"));
			global::java.security.KeyFactorySpi._engineGeneratePublic17306 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactorySpi.staticClass, "engineGeneratePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;");
			global::java.security.KeyFactorySpi._engineGeneratePrivate17307 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactorySpi.staticClass, "engineGeneratePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;");
			global::java.security.KeyFactorySpi._engineGetKeySpec17308 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactorySpi.staticClass, "engineGetKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;");
			global::java.security.KeyFactorySpi._engineTranslateKey17309 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactorySpi.staticClass, "engineTranslateKey", "(Ljava/security/Key;)Ljava/security/Key;");
			global::java.security.KeyFactorySpi._KeyFactorySpi17310 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactorySpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyFactorySpi))]
	public sealed partial class KeyFactorySpi_ : java.security.KeyFactorySpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyFactorySpi_()
		{
			InitJNI();
		}
		internal KeyFactorySpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGeneratePublic17311;
		protected override global::java.security.PublicKey engineGeneratePublic(java.security.spec.KeySpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyFactorySpi_._engineGeneratePublic17311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PublicKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PublicKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyFactorySpi_.staticClass, global::java.security.KeyFactorySpi_._engineGeneratePublic17311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PublicKey;
		}
		internal static global::MonoJavaBridge.MethodId _engineGeneratePrivate17312;
		protected override global::java.security.PrivateKey engineGeneratePrivate(java.security.spec.KeySpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyFactorySpi_._engineGeneratePrivate17312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PrivateKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyFactorySpi_.staticClass, global::java.security.KeyFactorySpi_._engineGeneratePrivate17312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PrivateKey;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetKeySpec17313;
		protected override global::java.security.spec.KeySpec engineGetKeySpec(java.security.Key arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.KeySpec>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyFactorySpi_._engineGetKeySpec17313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.spec.KeySpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.KeySpec>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyFactorySpi_.staticClass, global::java.security.KeyFactorySpi_._engineGetKeySpec17313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.spec.KeySpec;
		}
		internal static global::MonoJavaBridge.MethodId _engineTranslateKey17314;
		protected override global::java.security.Key engineTranslateKey(java.security.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyFactorySpi_._engineTranslateKey17314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyFactorySpi_.staticClass, global::java.security.KeyFactorySpi_._engineTranslateKey17314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.Key;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyFactorySpi"));
			global::java.security.KeyFactorySpi_._engineGeneratePublic17311 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactorySpi_.staticClass, "engineGeneratePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;");
			global::java.security.KeyFactorySpi_._engineGeneratePrivate17312 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactorySpi_.staticClass, "engineGeneratePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;");
			global::java.security.KeyFactorySpi_._engineGetKeySpec17313 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactorySpi_.staticClass, "engineGetKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;");
			global::java.security.KeyFactorySpi_._engineTranslateKey17314 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactorySpi_.staticClass, "engineTranslateKey", "(Ljava/security/Key;)Ljava/security/Key;");
		}
	}
}
