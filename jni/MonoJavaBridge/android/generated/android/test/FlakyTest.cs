namespace android.test
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.FlakyTest_))]
	public interface FlakyTest : java.lang.annotation.Annotation
	{
		int tolerance();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.FlakyTest))]
	public sealed partial class FlakyTest_ : java.lang.Object, FlakyTest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FlakyTest_()
		{
			InitJNI();
		}
		internal FlakyTest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _tolerance7656;
		 int android.test.FlakyTest.tolerance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.FlakyTest_._tolerance7656);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.FlakyTest_.staticClass, global::android.test.FlakyTest_._tolerance7656);
		}
		internal static global::MonoJavaBridge.MethodId _equals7657;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.FlakyTest_._equals7657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.FlakyTest_.staticClass, global::android.test.FlakyTest_._equals7657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString7658;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.FlakyTest_._toString7658)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.FlakyTest_.staticClass, global::android.test.FlakyTest_._toString7658)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode7659;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.FlakyTest_._hashCode7659);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.FlakyTest_.staticClass, global::android.test.FlakyTest_._hashCode7659);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType7660;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.FlakyTest_._annotationType7660)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.FlakyTest_.staticClass, global::android.test.FlakyTest_._annotationType7660)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.FlakyTest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/FlakyTest"));
			global::android.test.FlakyTest_._tolerance7656 = @__env.GetMethodIDNoThrow(global::android.test.FlakyTest_.staticClass, "tolerance", "()I");
			global::android.test.FlakyTest_._equals7657 = @__env.GetMethodIDNoThrow(global::android.test.FlakyTest_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.test.FlakyTest_._toString7658 = @__env.GetMethodIDNoThrow(global::android.test.FlakyTest_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.test.FlakyTest_._hashCode7659 = @__env.GetMethodIDNoThrow(global::android.test.FlakyTest_.staticClass, "hashCode", "()I");
			global::android.test.FlakyTest_._annotationType7660 = @__env.GetMethodIDNoThrow(global::android.test.FlakyTest_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
