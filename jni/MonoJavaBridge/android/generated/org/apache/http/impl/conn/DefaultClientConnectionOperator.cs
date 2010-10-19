namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultClientConnectionOperator : java.lang.Object, org.apache.http.conn.ClientConnectionOperator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultClientConnectionOperator()
		{
			InitJNI();
		}
		protected DefaultClientConnectionOperator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _openConnection26297;
		public virtual void openConnection(org.apache.http.conn.OperatedClientConnection arg0, org.apache.http.HttpHost arg1, java.net.InetAddress arg2, org.apache.http.protocol.HttpContext arg3, org.apache.http.@params.HttpParams arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._openConnection26297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._openConnection26297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _createConnection26298;
		public virtual global::org.apache.http.conn.OperatedClientConnection createConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.OperatedClientConnection>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._createConnection26298)) as org.apache.http.conn.OperatedClientConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.conn.OperatedClientConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._createConnection26298)) as org.apache.http.conn.OperatedClientConnection;
		}
		internal static global::MonoJavaBridge.MethodId _updateSecureConnection26299;
		public virtual void updateSecureConnection(org.apache.http.conn.OperatedClientConnection arg0, org.apache.http.HttpHost arg1, org.apache.http.protocol.HttpContext arg2, org.apache.http.@params.HttpParams arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._updateSecureConnection26299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._updateSecureConnection26299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _prepareSocket26300;
		protected virtual void prepareSocket(java.net.Socket arg0, org.apache.http.protocol.HttpContext arg1, org.apache.http.@params.HttpParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._prepareSocket26300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._prepareSocket26300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _DefaultClientConnectionOperator26301;
		public DefaultClientConnectionOperator(org.apache.http.conn.scheme.SchemeRegistry arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, global::org.apache.http.impl.conn.DefaultClientConnectionOperator._DefaultClientConnectionOperator26301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/DefaultClientConnectionOperator"));
			global::org.apache.http.impl.conn.DefaultClientConnectionOperator._openConnection26297 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, "openConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Ljava/net/InetAddress;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.DefaultClientConnectionOperator._createConnection26298 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, "createConnection", "()Lorg/apache/http/conn/OperatedClientConnection;");
			global::org.apache.http.impl.conn.DefaultClientConnectionOperator._updateSecureConnection26299 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, "updateSecureConnection", "(Lorg/apache/http/conn/OperatedClientConnection;Lorg/apache/http/HttpHost;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.DefaultClientConnectionOperator._prepareSocket26300 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, "prepareSocket", "(Ljava/net/Socket;Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/@params/HttpParams;)V");
			global::org.apache.http.impl.conn.DefaultClientConnectionOperator._DefaultClientConnectionOperator26301 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.DefaultClientConnectionOperator.staticClass, "<init>", "(Lorg/apache/http/conn/scheme/SchemeRegistry;)V");
		}
	}
}
