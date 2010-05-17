namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SyncContext : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SyncContext() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.SyncContext), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.SyncContext(@__env); 
			} 
		} 
		protected SyncContext(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinished1482; 
		public virtual void onFinished(android.content.SyncResult arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncContext)) 
				@__env.CallVoidMethod(this, _onFinished1482, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.SyncContext.staticClass, _onFinished1482, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSyncContextBinder1483; 
		public virtual android.os.IBinder getSyncContextBinder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncContext)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, _getSyncContextBinder1483)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.SyncContext.staticClass, _getSyncContextBinder1483)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.SyncContext.staticClass = @__class; 
			global::android.content.SyncContext._onFinished1482 = @__env.GetMethodID(global::android.content.SyncContext.staticClass, "onFinished", "(Landroid/content/SyncResult;)V"); 
			global::android.content.SyncContext._getSyncContextBinder1483 = @__env.GetMethodID(global::android.content.SyncContext.staticClass, "getSyncContextBinder", "()Landroid/os/IBinder;"); 
		} 
	} 
} 
