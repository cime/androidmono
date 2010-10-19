namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FloatMath : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FloatMath()
		{
			InitJNI();
		}
		protected FloatMath(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _sin9064;
		public static float sin(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._sin9064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cos9065;
		public static float cos(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._cos9065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sqrt9066;
		public static float sqrt(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._sqrt9066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ceil9067;
		public static float ceil(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._ceil9067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floor9068;
		public static float floor(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._floor9068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.FloatMath.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/FloatMath"));
			global::android.util.FloatMath._sin9064 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "sin", "(F)F");
			global::android.util.FloatMath._cos9065 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "cos", "(F)F");
			global::android.util.FloatMath._sqrt9066 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "sqrt", "(F)F");
			global::android.util.FloatMath._ceil9067 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "ceil", "(F)F");
			global::android.util.FloatMath._floor9068 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "floor", "(F)F");
		}
	}
}
