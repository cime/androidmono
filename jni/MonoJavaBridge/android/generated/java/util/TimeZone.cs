namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.TimeZone_))]
	public abstract partial class TimeZone : java.lang.Object, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimeZone()
		{
			InitJNI();
		}
		protected TimeZone(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone20887;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._clone20887)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._clone20887)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getDefault20888;
		public static global::java.util.TimeZone getDefault() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._getDefault20888)) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _getOffset20889;
		public virtual int getOffset(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TimeZone._getOffset20889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getOffset20889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffset20890;
		public abstract int getOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
		internal static global::MonoJavaBridge.MethodId _setDefault20891;
		public static void setDefault(java.util.TimeZone arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._setDefault20891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName20892;
		public virtual global::java.lang.String getDisplayName(bool arg0, int arg1, java.util.Locale arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getDisplayName20892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName20892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName20893;
		public virtual global::java.lang.String getDisplayName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getDisplayName20893)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName20893)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName20894;
		public virtual global::java.lang.String getDisplayName(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getDisplayName20894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName20894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName20895;
		public virtual global::java.lang.String getDisplayName(bool arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getDisplayName20895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName20895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZone20896;
		public static global::java.util.TimeZone getTimeZone(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._getTimeZone20896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _getRawOffset20897;
		public abstract int getRawOffset();
		internal static global::MonoJavaBridge.MethodId _getID20898;
		public virtual global::java.lang.String getID() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getID20898)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getID20898)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasSameRules20899;
		public virtual bool hasSameRules(java.util.TimeZone arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TimeZone._hasSameRules20899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._hasSameRules20899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRawOffset20900;
		public abstract void setRawOffset(int arg0);
		internal static global::MonoJavaBridge.MethodId _setID20901;
		public virtual void setID(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.TimeZone._setID20901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._setID20901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDSTSavings20902;
		public virtual int getDSTSavings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TimeZone._getDSTSavings20902);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDSTSavings20902);
		}
		internal static global::MonoJavaBridge.MethodId _useDaylightTime20903;
		public abstract bool useDaylightTime();
		internal static global::MonoJavaBridge.MethodId _inDaylightTime20904;
		public abstract bool inDaylightTime(java.util.Date arg0);
		internal static global::MonoJavaBridge.MethodId _getAvailableIDs20905;
		public static global::java.lang.String[] getAvailableIDs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._getAvailableIDs20905)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableIDs20906;
		public static global::java.lang.String[] getAvailableIDs(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._getAvailableIDs20906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _TimeZone20907;
		public TimeZone()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TimeZone.staticClass, global::java.util.TimeZone._TimeZone20907);
			Init(@__env, handle);
		}
		public static int SHORT
		{
			get
			{
				return 0;
			}
		}
		public static int LONG
		{
			get
			{
				return 1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimeZone.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimeZone"));
			global::java.util.TimeZone._clone20887 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.TimeZone._getDefault20888 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDefault", "()Ljava/util/TimeZone;");
			global::java.util.TimeZone._getOffset20889 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getOffset", "(J)I");
			global::java.util.TimeZone._getOffset20890 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getOffset", "(IIIIII)I");
			global::java.util.TimeZone._setDefault20891 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "setDefault", "(Ljava/util/TimeZone;)V");
			global::java.util.TimeZone._getDisplayName20892 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDisplayName", "(ZILjava/util/Locale;)Ljava/lang/String;");
			global::java.util.TimeZone._getDisplayName20893 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDisplayName", "()Ljava/lang/String;");
			global::java.util.TimeZone._getDisplayName20894 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.TimeZone._getDisplayName20895 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDisplayName", "(ZI)Ljava/lang/String;");
			global::java.util.TimeZone._getTimeZone20896 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;");
			global::java.util.TimeZone._getRawOffset20897 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getRawOffset", "()I");
			global::java.util.TimeZone._getID20898 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getID", "()Ljava/lang/String;");
			global::java.util.TimeZone._hasSameRules20899 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "hasSameRules", "(Ljava/util/TimeZone;)Z");
			global::java.util.TimeZone._setRawOffset20900 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "setRawOffset", "(I)V");
			global::java.util.TimeZone._setID20901 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "setID", "(Ljava/lang/String;)V");
			global::java.util.TimeZone._getDSTSavings20902 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDSTSavings", "()I");
			global::java.util.TimeZone._useDaylightTime20903 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "useDaylightTime", "()Z");
			global::java.util.TimeZone._inDaylightTime20904 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "inDaylightTime", "(Ljava/util/Date;)Z");
			global::java.util.TimeZone._getAvailableIDs20905 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getAvailableIDs", "()[Ljava/lang/String;");
			global::java.util.TimeZone._getAvailableIDs20906 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getAvailableIDs", "(I)[Ljava/lang/String;");
			global::java.util.TimeZone._TimeZone20907 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.TimeZone))]
	public sealed partial class TimeZone_ : java.util.TimeZone
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimeZone_()
		{
			InitJNI();
		}
		internal TimeZone_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOffset20908;
		public override int getOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TimeZone_._getOffset20908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._getOffset20908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _getRawOffset20909;
		public override int getRawOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TimeZone_._getRawOffset20909);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._getRawOffset20909);
		}
		internal static global::MonoJavaBridge.MethodId _setRawOffset20910;
		public override void setRawOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.TimeZone_._setRawOffset20910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._setRawOffset20910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _useDaylightTime20911;
		public override bool useDaylightTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TimeZone_._useDaylightTime20911);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._useDaylightTime20911);
		}
		internal static global::MonoJavaBridge.MethodId _inDaylightTime20912;
		public override bool inDaylightTime(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TimeZone_._inDaylightTime20912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._inDaylightTime20912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimeZone_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimeZone"));
			global::java.util.TimeZone_._getOffset20908 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "getOffset", "(IIIIII)I");
			global::java.util.TimeZone_._getRawOffset20909 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "getRawOffset", "()I");
			global::java.util.TimeZone_._setRawOffset20910 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "setRawOffset", "(I)V");
			global::java.util.TimeZone_._useDaylightTime20911 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "useDaylightTime", "()Z");
			global::java.util.TimeZone_._inDaylightTime20912 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "inDaylightTime", "(Ljava/util/Date;)Z");
		}
	}
}
