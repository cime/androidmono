namespace org.xmlpull.v1
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XmlPullParserFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XmlPullParserFactory()
		{
			InitJNI();
		}
		protected XmlPullParserFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance28484;
		public static global::org.xmlpull.v1.XmlPullParserFactory newInstance(java.lang.String arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._newInstance28484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xmlpull.v1.XmlPullParserFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance28485;
		public static global::org.xmlpull.v1.XmlPullParserFactory newInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._newInstance28485)) as org.xmlpull.v1.XmlPullParserFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature28486;
		public virtual void setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory._setFeature28486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._setFeature28486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature28487;
		public virtual bool getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory._getFeature28487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._getFeature28487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newPullParser28488;
		public virtual global::org.xmlpull.v1.XmlPullParser newPullParser() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlPullParser>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory._newPullParser28488)) as org.xmlpull.v1.XmlPullParser;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlPullParser>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._newPullParser28488)) as org.xmlpull.v1.XmlPullParser;
		}
		internal static global::MonoJavaBridge.MethodId _newSerializer28489;
		public virtual global::org.xmlpull.v1.XmlSerializer newSerializer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory._newSerializer28489)) as org.xmlpull.v1.XmlSerializer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._newSerializer28489)) as org.xmlpull.v1.XmlSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware28490;
		public virtual bool isNamespaceAware() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory._isNamespaceAware28490);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._isNamespaceAware28490);
		}
		internal static global::MonoJavaBridge.MethodId _isValidating28491;
		public virtual bool isValidating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory._isValidating28491);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._isValidating28491);
		}
		internal static global::MonoJavaBridge.MethodId _setNamespaceAware28492;
		public virtual void setNamespaceAware(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory._setNamespaceAware28492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._setNamespaceAware28492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setValidating28493;
		public virtual void setValidating(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory._setValidating28493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._setValidating28493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _XmlPullParserFactory28494;
		protected XmlPullParserFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.XmlPullParserFactory.staticClass, global::org.xmlpull.v1.XmlPullParserFactory._XmlPullParserFactory28494);
			Init(@__env, handle);
		}
		public static global::java.lang.String PROPERTY_NAME
		{
			get
			{
				return "org.xmlpull.v1.XmlPullParserFactory";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.XmlPullParserFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/XmlPullParserFactory"));
			global::org.xmlpull.v1.XmlPullParserFactory._newInstance28484 = @__env.GetStaticMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/Class;)Lorg/xmlpull/v1/XmlPullParserFactory;");
			global::org.xmlpull.v1.XmlPullParserFactory._newInstance28485 = @__env.GetStaticMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "newInstance", "()Lorg/xmlpull/v1/XmlPullParserFactory;");
			global::org.xmlpull.v1.XmlPullParserFactory._setFeature28486 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::org.xmlpull.v1.XmlPullParserFactory._getFeature28487 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::org.xmlpull.v1.XmlPullParserFactory._newPullParser28488 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "newPullParser", "()Lorg/xmlpull/v1/XmlPullParser;");
			global::org.xmlpull.v1.XmlPullParserFactory._newSerializer28489 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "newSerializer", "()Lorg/xmlpull/v1/XmlSerializer;");
			global::org.xmlpull.v1.XmlPullParserFactory._isNamespaceAware28490 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "isNamespaceAware", "()Z");
			global::org.xmlpull.v1.XmlPullParserFactory._isValidating28491 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "isValidating", "()Z");
			global::org.xmlpull.v1.XmlPullParserFactory._setNamespaceAware28492 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "setNamespaceAware", "(Z)V");
			global::org.xmlpull.v1.XmlPullParserFactory._setValidating28493 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "setValidating", "(Z)V");
			global::org.xmlpull.v1.XmlPullParserFactory._XmlPullParserFactory28494 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserFactory.staticClass, "<init>", "()V");
		}
	}
}
