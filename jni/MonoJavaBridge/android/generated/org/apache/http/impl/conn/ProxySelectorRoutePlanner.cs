namespace org.apache.http.impl.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProxySelectorRoutePlanner : java.lang.Object, org.apache.http.conn.routing.HttpRoutePlanner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProxySelectorRoutePlanner()
		{
			InitJNI();
		}
		protected ProxySelectorRoutePlanner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getHost26328;
		protected virtual global::java.lang.String getHost(java.net.InetSocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._getHost26328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._getHost26328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _determineRoute26329;
		public virtual global::org.apache.http.conn.routing.HttpRoute determineRoute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._determineRoute26329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.conn.routing.HttpRoute;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._determineRoute26329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.conn.routing.HttpRoute;
		}
		public new global::java.net.ProxySelector ProxySelector
		{
			get
			{
				return getProxySelector();
			}
			set
			{
				setProxySelector(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProxySelector26330;
		public virtual global::java.net.ProxySelector getProxySelector() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._getProxySelector26330)) as java.net.ProxySelector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._getProxySelector26330)) as java.net.ProxySelector;
		}
		internal static global::MonoJavaBridge.MethodId _setProxySelector26331;
		public virtual void setProxySelector(java.net.ProxySelector arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._setProxySelector26331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._setProxySelector26331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _determineProxy26332;
		protected virtual global::org.apache.http.HttpHost determineProxy(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._determineProxy26332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._determineProxy26332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HttpHost;
		}
		internal static global::MonoJavaBridge.MethodId _chooseProxy26333;
		protected virtual global::java.net.Proxy chooseProxy(java.util.List arg0, org.apache.http.HttpHost arg1, org.apache.http.HttpRequest arg2, org.apache.http.protocol.HttpContext arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._chooseProxy26333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Proxy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._chooseProxy26333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Proxy;
		}
		internal static global::MonoJavaBridge.MethodId _ProxySelectorRoutePlanner26334;
		public ProxySelectorRoutePlanner(org.apache.http.conn.scheme.SchemeRegistry arg0, java.net.ProxySelector arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._ProxySelectorRoutePlanner26334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/ProxySelectorRoutePlanner"));
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._getHost26328 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "getHost", "(Ljava/net/InetSocketAddress;)Ljava/lang/String;");
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._determineRoute26329 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "determineRoute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/conn/routing/HttpRoute;");
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._getProxySelector26330 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "getProxySelector", "()Ljava/net/ProxySelector;");
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._setProxySelector26331 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "setProxySelector", "(Ljava/net/ProxySelector;)V");
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._determineProxy26332 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "determineProxy", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpHost;");
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._chooseProxy26333 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "chooseProxy", "(Ljava/util/List;Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Ljava/net/Proxy;");
			global::org.apache.http.impl.conn.ProxySelectorRoutePlanner._ProxySelectorRoutePlanner26334 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.ProxySelectorRoutePlanner.staticClass, "<init>", "(Lorg/apache/http/conn/scheme/SchemeRegistry;Ljava/net/ProxySelector;)V");
		}
	}
}
