namespace android.view.animation 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LinearInterpolator : java.lang.Object, Interpolator
	{ 
		internal static global::java.lang.Class staticClass; 
		static LinearInterpolator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.animation.LinearInterpolator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.animation.LinearInterpolator(@__env); 
			} 
		} 
		protected LinearInterpolator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolation8342; 
		public virtual float getInterpolation(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.LinearInterpolator)) 
				return @__env.CallFloatMethod(this, _getInterpolation8342, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.animation.LinearInterpolator.staticClass, _getInterpolation8342, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LinearInterpolator8343; 
		public LinearInterpolator()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.LinearInterpolator.staticClass, _LinearInterpolator8343, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LinearInterpolator8344; 
		public LinearInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.LinearInterpolator.staticClass, _LinearInterpolator8344, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.animation.LinearInterpolator.staticClass = @__class; 
			global::android.view.animation.LinearInterpolator._getInterpolation8342 = @__env.GetMethodID(global::android.view.animation.LinearInterpolator.staticClass, "getInterpolation", "(F)F"); 
			global::android.view.animation.LinearInterpolator._LinearInterpolator8343 = @__env.GetMethodID(global::android.view.animation.LinearInterpolator.staticClass, "<init>", "()V"); 
			global::android.view.animation.LinearInterpolator._LinearInterpolator8344 = @__env.GetMethodID(global::android.view.animation.LinearInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 