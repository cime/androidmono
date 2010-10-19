namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParserFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ParserFactory()
		{
			InitJNI();
		}
		protected ParserFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _makeParser28380;
		public static global::org.xml.sax.Parser makeParser() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.Parser>(@__env.CallStaticObjectMethod(org.xml.sax.helpers.ParserFactory.staticClass, global::org.xml.sax.helpers.ParserFactory._makeParser28380)) as org.xml.sax.Parser;
		}
		internal static global::MonoJavaBridge.MethodId _makeParser28381;
		public static global::org.xml.sax.Parser makeParser(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.Parser>(@__env.CallStaticObjectMethod(org.xml.sax.helpers.ParserFactory.staticClass, global::org.xml.sax.helpers.ParserFactory._makeParser28381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.xml.sax.Parser;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.ParserFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/ParserFactory"));
			global::org.xml.sax.helpers.ParserFactory._makeParser28380 = @__env.GetStaticMethodIDNoThrow(global::org.xml.sax.helpers.ParserFactory.staticClass, "makeParser", "()Lorg/xml/sax/Parser;");
			global::org.xml.sax.helpers.ParserFactory._makeParser28381 = @__env.GetStaticMethodIDNoThrow(global::org.xml.sax.helpers.ParserFactory.staticClass, "makeParser", "(Ljava/lang/String;)Lorg/xml/sax/Parser;");
		}
	}
}
