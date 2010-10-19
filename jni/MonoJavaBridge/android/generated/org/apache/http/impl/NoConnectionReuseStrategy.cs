namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoConnectionReuseStrategy : java.lang.Object, ConnectionReuseStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoConnectionReuseStrategy()
		{
			InitJNI();
		}
		protected NoConnectionReuseStrategy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _keepAlive25925;
		public virtual bool keepAlive(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.NoConnectionReuseStrategy._keepAlive25925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.NoConnectionReuseStrategy.staticClass, global::org.apache.http.impl.NoConnectionReuseStrategy._keepAlive25925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _NoConnectionReuseStrategy25926;
		public NoConnectionReuseStrategy()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.NoConnectionReuseStrategy.staticClass, global::org.apache.http.impl.NoConnectionReuseStrategy._NoConnectionReuseStrategy25926);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.NoConnectionReuseStrategy.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/NoConnectionReuseStrategy"));
			global::org.apache.http.impl.NoConnectionReuseStrategy._keepAlive25925 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.NoConnectionReuseStrategy.staticClass, "keepAlive", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z");
			global::org.apache.http.impl.NoConnectionReuseStrategy._NoConnectionReuseStrategy25926 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.NoConnectionReuseStrategy.staticClass, "<init>", "()V");
		}
	}
}
