namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Annotation : java.lang.Object, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Annotation()
		{
			InitJNI();
		}
		protected Annotation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Value
		{
			get
			{
				return getValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValue8143;
		public virtual global::java.lang.String getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Annotation._getValue8143)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Annotation.staticClass, global::android.text.Annotation._getValue8143)) as java.lang.String;
		}
		public new global::java.lang.String Key
		{
			get
			{
				return getKey();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKey8144;
		public virtual global::java.lang.String getKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Annotation._getKey8144)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Annotation.staticClass, global::android.text.Annotation._getKey8144)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8145;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Annotation._writeToParcel8145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Annotation.staticClass, global::android.text.Annotation._writeToParcel8145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8146;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Annotation._describeContents8146);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Annotation.staticClass, global::android.text.Annotation._describeContents8146);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId8147;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Annotation._getSpanTypeId8147);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Annotation.staticClass, global::android.text.Annotation._getSpanTypeId8147);
		}
		internal static global::MonoJavaBridge.MethodId _Annotation8148;
		public Annotation(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Annotation.staticClass, global::android.text.Annotation._Annotation8148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Annotation8149;
		public Annotation(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Annotation.staticClass, global::android.text.Annotation._Annotation8149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Annotation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Annotation"));
			global::android.text.Annotation._getValue8143 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "getValue", "()Ljava/lang/String;");
			global::android.text.Annotation._getKey8144 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "getKey", "()Ljava/lang/String;");
			global::android.text.Annotation._writeToParcel8145 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.Annotation._describeContents8146 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "describeContents", "()I");
			global::android.text.Annotation._getSpanTypeId8147 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "getSpanTypeId", "()I");
			global::android.text.Annotation._Annotation8148 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.text.Annotation._Annotation8149 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
