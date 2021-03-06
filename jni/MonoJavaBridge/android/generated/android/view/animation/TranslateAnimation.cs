namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TranslateAnimation : android.view.animation.Animation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TranslateAnimation()
		{
			InitJNI();
		}
		protected TranslateAnimation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _initialize10073;
		public override void initialize(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.TranslateAnimation._initialize10073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.TranslateAnimation.staticClass, global::android.view.animation.TranslateAnimation._initialize10073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _applyTransformation10074;
		protected override void applyTransformation(float arg0, android.view.animation.Transformation arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.TranslateAnimation._applyTransformation10074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.TranslateAnimation.staticClass, global::android.view.animation.TranslateAnimation._applyTransformation10074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _TranslateAnimation10075;
		public TranslateAnimation(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.TranslateAnimation.staticClass, global::android.view.animation.TranslateAnimation._TranslateAnimation10075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TranslateAnimation10076;
		public TranslateAnimation(float arg0, float arg1, float arg2, float arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.TranslateAnimation.staticClass, global::android.view.animation.TranslateAnimation._TranslateAnimation10076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TranslateAnimation10077;
		public TranslateAnimation(int arg0, float arg1, int arg2, float arg3, int arg4, float arg5, int arg6, float arg7)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.TranslateAnimation.staticClass, global::android.view.animation.TranslateAnimation._TranslateAnimation10077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.TranslateAnimation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/TranslateAnimation"));
			global::android.view.animation.TranslateAnimation._initialize10073 = @__env.GetMethodIDNoThrow(global::android.view.animation.TranslateAnimation.staticClass, "initialize", "(IIII)V");
			global::android.view.animation.TranslateAnimation._applyTransformation10074 = @__env.GetMethodIDNoThrow(global::android.view.animation.TranslateAnimation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V");
			global::android.view.animation.TranslateAnimation._TranslateAnimation10075 = @__env.GetMethodIDNoThrow(global::android.view.animation.TranslateAnimation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.animation.TranslateAnimation._TranslateAnimation10076 = @__env.GetMethodIDNoThrow(global::android.view.animation.TranslateAnimation.staticClass, "<init>", "(FFFF)V");
			global::android.view.animation.TranslateAnimation._TranslateAnimation10077 = @__env.GetMethodIDNoThrow(global::android.view.animation.TranslateAnimation.staticClass, "<init>", "(IFIFIFIF)V");
		}
	}
}
