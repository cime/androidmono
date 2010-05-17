namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SslErrorHandler : android.os.Handler
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SslErrorHandler() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.SslErrorHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.SslErrorHandler(@__env); 
			} 
		} 
		protected SslErrorHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel8647; 
		public virtual void cancel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.SslErrorHandler)) 
				@__env.CallVoidMethod(this, _cancel8647); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.SslErrorHandler.staticClass, _cancel8647); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _handleMessage8648; 
		public override void handleMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.SslErrorHandler)) 
				@__env.CallVoidMethod(this, _handleMessage8648, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.SslErrorHandler.staticClass, _handleMessage8648, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _proceed8649; 
		public virtual void proceed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.SslErrorHandler)) 
				@__env.CallVoidMethod(this, _proceed8649); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.SslErrorHandler.staticClass, _proceed8649); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.SslErrorHandler.staticClass = @__class; 
			global::android.webkit.SslErrorHandler._cancel8647 = @__env.GetMethodID(global::android.webkit.SslErrorHandler.staticClass, "cancel", "()V"); 
			global::android.webkit.SslErrorHandler._handleMessage8648 = @__env.GetMethodID(global::android.webkit.SslErrorHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V"); 
			global::android.webkit.SslErrorHandler._proceed8649 = @__env.GetMethodID(global::android.webkit.SslErrorHandler.staticClass, "proceed", "()V"); 
		} 
	} 
} 
