namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnConnectionParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnConnectionParamBean()
		{
			InitJNI();
		}
		protected ConnConnectionParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setMaxStatusLineGarbage25472;
		public virtual void setMaxStatusLineGarbage(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnConnectionParamBean._setMaxStatusLineGarbage25472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnConnectionParamBean.staticClass, global::org.apache.http.conn.@params.ConnConnectionParamBean._setMaxStatusLineGarbage25472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConnConnectionParamBean25473;
		public ConnConnectionParamBean(org.apache.http.@params.HttpParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnConnectionParamBean.staticClass, global::org.apache.http.conn.@params.ConnConnectionParamBean._ConnConnectionParamBean25473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnConnectionParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/@params/ConnConnectionParamBean"));
			global::org.apache.http.conn.@params.ConnConnectionParamBean._setMaxStatusLineGarbage25472 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnConnectionParamBean.staticClass, "setMaxStatusLineGarbage", "(I)V");
			global::org.apache.http.conn.@params.ConnConnectionParamBean._ConnConnectionParamBean25473 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnConnectionParamBean.staticClass, "<init>", "(Lorg/apache/http/@params/HttpParams;)V");
		}
	}
}
