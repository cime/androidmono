namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicSecureHandler : org.apache.http.impl.cookie.AbstractCookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicSecureHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33265;
		public override void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicSecureHandler._parse33265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicSecureHandler.staticClass, global::org.apache.http.impl.cookie.BasicSecureHandler._parse33265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _match33266;
		public override bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicSecureHandler._match33266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BasicSecureHandler.staticClass, global::org.apache.http.impl.cookie.BasicSecureHandler._match33266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicSecureHandler33267;
		public BasicSecureHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BasicSecureHandler.staticClass, global::org.apache.http.impl.cookie.BasicSecureHandler._BasicSecureHandler33267);
			Init(@__env, handle);
		}
		static BasicSecureHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.BasicSecureHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/BasicSecureHandler"));
			global::org.apache.http.impl.cookie.BasicSecureHandler._parse33265 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicSecureHandler.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.BasicSecureHandler._match33266 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicSecureHandler.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.impl.cookie.BasicSecureHandler._BasicSecureHandler33267 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicSecureHandler.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}