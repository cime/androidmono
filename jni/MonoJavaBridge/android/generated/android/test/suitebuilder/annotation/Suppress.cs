namespace android.test.suitebuilder.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.suitebuilder.annotation.Suppress_))]
	public interface Suppress : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.suitebuilder.annotation.Suppress))]
	public sealed partial class Suppress_ : java.lang.Object, Suppress
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Suppress_()
		{
			InitJNI();
		}
		internal Suppress_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals8127;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Suppress_._equals8127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Suppress_.staticClass, global::android.test.suitebuilder.annotation.Suppress_._equals8127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString8128;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Suppress_._toString8128)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Suppress_.staticClass, global::android.test.suitebuilder.annotation.Suppress_._toString8128)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode8129;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Suppress_._hashCode8129);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Suppress_.staticClass, global::android.test.suitebuilder.annotation.Suppress_._hashCode8129);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType8130;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Suppress_._annotationType8130)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Suppress_.staticClass, global::android.test.suitebuilder.annotation.Suppress_._annotationType8130)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.suitebuilder.annotation.Suppress_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/annotation/Suppress"));
			global::android.test.suitebuilder.annotation.Suppress_._equals8127 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Suppress_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.test.suitebuilder.annotation.Suppress_._toString8128 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Suppress_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.test.suitebuilder.annotation.Suppress_._hashCode8129 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Suppress_.staticClass, "hashCode", "()I");
			global::android.test.suitebuilder.annotation.Suppress_._annotationType8130 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Suppress_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
