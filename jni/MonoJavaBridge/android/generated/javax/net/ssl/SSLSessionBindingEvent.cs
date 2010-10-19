namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLSessionBindingEvent : java.util.EventObject
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLSessionBindingEvent()
		{
			InitJNI();
		}
		protected SSLSessionBindingEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName23508;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionBindingEvent._getName23508)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionBindingEvent.staticClass, global::javax.net.ssl.SSLSessionBindingEvent._getName23508)) as java.lang.String;
		}
		public new global::javax.net.ssl.SSLSession Session
		{
			get
			{
				return getSession();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSession23509;
		public virtual global::javax.net.ssl.SSLSession getSession() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionBindingEvent._getSession23509)) as javax.net.ssl.SSLSession;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.net.ssl.SSLSession>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSessionBindingEvent.staticClass, global::javax.net.ssl.SSLSessionBindingEvent._getSession23509)) as javax.net.ssl.SSLSession;
		}
		internal static global::MonoJavaBridge.MethodId _SSLSessionBindingEvent23510;
		public SSLSessionBindingEvent(javax.net.ssl.SSLSession arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSessionBindingEvent.staticClass, global::javax.net.ssl.SSLSessionBindingEvent._SSLSessionBindingEvent23510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSessionBindingEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSessionBindingEvent"));
			global::javax.net.ssl.SSLSessionBindingEvent._getName23508 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionBindingEvent.staticClass, "getName", "()Ljava/lang/String;");
			global::javax.net.ssl.SSLSessionBindingEvent._getSession23509 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionBindingEvent.staticClass, "getSession", "()Ljavax/net/ssl/SSLSession;");
			global::javax.net.ssl.SSLSessionBindingEvent._SSLSessionBindingEvent23510 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSessionBindingEvent.staticClass, "<init>", "(Ljavax/net/ssl/SSLSession;Ljava/lang/String;)V");
		}
	}
}
