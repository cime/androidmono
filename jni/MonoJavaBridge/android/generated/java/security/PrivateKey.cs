namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.PrivateKey_))]
	public interface PrivateKey : Key
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.PrivateKey))]
	public sealed partial class PrivateKey_ : java.lang.Object, PrivateKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PrivateKey_()
		{
			InitJNI();
		}
		internal PrivateKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded17525;
		 byte[] java.security.Key.getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PrivateKey_._getEncoded17525)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PrivateKey_.staticClass, global::java.security.PrivateKey_._getEncoded17525)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm17526;
		 global::java.lang.String java.security.Key.getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PrivateKey_._getAlgorithm17526)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PrivateKey_.staticClass, global::java.security.PrivateKey_._getAlgorithm17526)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFormat17527;
		 global::java.lang.String java.security.Key.getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.PrivateKey_._getFormat17527)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.PrivateKey_.staticClass, global::java.security.PrivateKey_._getFormat17527)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PrivateKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PrivateKey"));
			global::java.security.PrivateKey_._getEncoded17525 = @__env.GetMethodIDNoThrow(global::java.security.PrivateKey_.staticClass, "getEncoded", "()[B");
			global::java.security.PrivateKey_._getAlgorithm17526 = @__env.GetMethodIDNoThrow(global::java.security.PrivateKey_.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.PrivateKey_._getFormat17527 = @__env.GetMethodIDNoThrow(global::java.security.PrivateKey_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
	}
}
