namespace android.test
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.PerformanceTestCase_))]
	public interface PerformanceTestCase  : global::MonoJavaBridge.IJavaObject 
	{
		int startPerformance(android.test.PerformanceTestCase_Intermediates arg0);
		bool isPerformanceOnly();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.PerformanceTestCase))]
	public sealed partial class PerformanceTestCase_ : java.lang.Object, PerformanceTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PerformanceTestCase_()
		{
			InitJNI();
		}
		internal PerformanceTestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _startPerformance7737;
		 int android.test.PerformanceTestCase.startPerformance(android.test.PerformanceTestCase_Intermediates arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.PerformanceTestCase_._startPerformance7737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.PerformanceTestCase_.staticClass, global::android.test.PerformanceTestCase_._startPerformance7737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPerformanceOnly7738;
		 bool android.test.PerformanceTestCase.isPerformanceOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.PerformanceTestCase_._isPerformanceOnly7738);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.PerformanceTestCase_.staticClass, global::android.test.PerformanceTestCase_._isPerformanceOnly7738);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.PerformanceTestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/PerformanceTestCase"));
			global::android.test.PerformanceTestCase_._startPerformance7737 = @__env.GetMethodIDNoThrow(global::android.test.PerformanceTestCase_.staticClass, "startPerformance", "(Landroid/test/PerformanceTestCase$Intermediates;)I");
			global::android.test.PerformanceTestCase_._isPerformanceOnly7738 = @__env.GetMethodIDNoThrow(global::android.test.PerformanceTestCase_.staticClass, "isPerformanceOnly", "()Z");
		}
	}
}
