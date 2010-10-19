namespace android.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.util.AttributeSet_))]
	public interface AttributeSet  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getAttributeValue(int arg0);
		global::java.lang.String getAttributeValue(java.lang.String arg0, java.lang.String arg1);
		int getAttributeCount();
		global::java.lang.String getAttributeName(int arg0);
		global::java.lang.String getPositionDescription();
		int getAttributeNameResource(int arg0);
		int getAttributeListValue(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, int arg3);
		int getAttributeListValue(int arg0, java.lang.String[] arg1, int arg2);
		bool getAttributeBooleanValue(java.lang.String arg0, java.lang.String arg1, bool arg2);
		bool getAttributeBooleanValue(int arg0, bool arg1);
		int getAttributeResourceValue(java.lang.String arg0, java.lang.String arg1, int arg2);
		int getAttributeResourceValue(int arg0, int arg1);
		int getAttributeIntValue(int arg0, int arg1);
		int getAttributeIntValue(java.lang.String arg0, java.lang.String arg1, int arg2);
		int getAttributeUnsignedIntValue(java.lang.String arg0, java.lang.String arg1, int arg2);
		int getAttributeUnsignedIntValue(int arg0, int arg1);
		float getAttributeFloatValue(java.lang.String arg0, java.lang.String arg1, float arg2);
		float getAttributeFloatValue(int arg0, float arg1);
		global::java.lang.String getIdAttribute();
		global::java.lang.String getClassAttribute();
		int getIdAttributeResourceValue(int arg0);
		int getStyleAttribute();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.util.AttributeSet))]
	public sealed partial class AttributeSet_ : java.lang.Object, AttributeSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AttributeSet_()
		{
			InitJNI();
		}
		internal AttributeSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue8989;
		 global::java.lang.String android.util.AttributeSet.getAttributeValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeValue8989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeValue8989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeValue8990;
		 global::java.lang.String android.util.AttributeSet.getAttributeValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeValue8990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeValue8990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeCount8991;
		 int android.util.AttributeSet.getAttributeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeCount8991);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeCount8991);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeName8992;
		 global::java.lang.String android.util.AttributeSet.getAttributeName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeName8992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeName8992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPositionDescription8993;
		 global::java.lang.String android.util.AttributeSet.getPositionDescription() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.AttributeSet_._getPositionDescription8993)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getPositionDescription8993)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeNameResource8994;
		 int android.util.AttributeSet.getAttributeNameResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeNameResource8994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeNameResource8994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeListValue8995;
		 int android.util.AttributeSet.getAttributeListValue(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeListValue8995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeListValue8995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeListValue8996;
		 int android.util.AttributeSet.getAttributeListValue(int arg0, java.lang.String[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeListValue8996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeListValue8996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeBooleanValue8997;
		 bool android.util.AttributeSet.getAttributeBooleanValue(java.lang.String arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeBooleanValue8997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeBooleanValue8997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeBooleanValue8998;
		 bool android.util.AttributeSet.getAttributeBooleanValue(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeBooleanValue8998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeBooleanValue8998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeResourceValue8999;
		 int android.util.AttributeSet.getAttributeResourceValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeResourceValue8999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeResourceValue8999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeResourceValue9000;
		 int android.util.AttributeSet.getAttributeResourceValue(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeResourceValue9000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeResourceValue9000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeIntValue9001;
		 int android.util.AttributeSet.getAttributeIntValue(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeIntValue9001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeIntValue9001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeIntValue9002;
		 int android.util.AttributeSet.getAttributeIntValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeIntValue9002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeIntValue9002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeUnsignedIntValue9003;
		 int android.util.AttributeSet.getAttributeUnsignedIntValue(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeUnsignedIntValue9003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeUnsignedIntValue9003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeUnsignedIntValue9004;
		 int android.util.AttributeSet.getAttributeUnsignedIntValue(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeUnsignedIntValue9004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeUnsignedIntValue9004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeFloatValue9005;
		 float android.util.AttributeSet.getAttributeFloatValue(java.lang.String arg0, java.lang.String arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeFloatValue9005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeFloatValue9005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeFloatValue9006;
		 float android.util.AttributeSet.getAttributeFloatValue(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.util.AttributeSet_._getAttributeFloatValue9006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getAttributeFloatValue9006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getIdAttribute9007;
		 global::java.lang.String android.util.AttributeSet.getIdAttribute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.AttributeSet_._getIdAttribute9007)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getIdAttribute9007)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getClassAttribute9008;
		 global::java.lang.String android.util.AttributeSet.getClassAttribute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.AttributeSet_._getClassAttribute9008)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getClassAttribute9008)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIdAttributeResourceValue9009;
		 int android.util.AttributeSet.getIdAttributeResourceValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getIdAttributeResourceValue9009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getIdAttributeResourceValue9009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStyleAttribute9010;
		 int android.util.AttributeSet.getStyleAttribute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.AttributeSet_._getStyleAttribute9010);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.AttributeSet_.staticClass, global::android.util.AttributeSet_._getStyleAttribute9010);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.AttributeSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/AttributeSet"));
			global::android.util.AttributeSet_._getAttributeValue8989 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeValue", "(I)Ljava/lang/String;");
			global::android.util.AttributeSet_._getAttributeValue8990 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.util.AttributeSet_._getAttributeCount8991 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeCount", "()I");
			global::android.util.AttributeSet_._getAttributeName8992 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeName", "(I)Ljava/lang/String;");
			global::android.util.AttributeSet_._getPositionDescription8993 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getPositionDescription", "()Ljava/lang/String;");
			global::android.util.AttributeSet_._getAttributeNameResource8994 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeNameResource", "(I)I");
			global::android.util.AttributeSet_._getAttributeListValue8995 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeListValue", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)I");
			global::android.util.AttributeSet_._getAttributeListValue8996 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeListValue", "(I[Ljava/lang/String;I)I");
			global::android.util.AttributeSet_._getAttributeBooleanValue8997 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			global::android.util.AttributeSet_._getAttributeBooleanValue8998 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeBooleanValue", "(IZ)Z");
			global::android.util.AttributeSet_._getAttributeResourceValue8999 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeResourceValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.util.AttributeSet_._getAttributeResourceValue9000 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeResourceValue", "(II)I");
			global::android.util.AttributeSet_._getAttributeIntValue9001 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeIntValue", "(II)I");
			global::android.util.AttributeSet_._getAttributeIntValue9002 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.util.AttributeSet_._getAttributeUnsignedIntValue9003 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeUnsignedIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.util.AttributeSet_._getAttributeUnsignedIntValue9004 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeUnsignedIntValue", "(II)I");
			global::android.util.AttributeSet_._getAttributeFloatValue9005 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeFloatValue", "(Ljava/lang/String;Ljava/lang/String;F)F");
			global::android.util.AttributeSet_._getAttributeFloatValue9006 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getAttributeFloatValue", "(IF)F");
			global::android.util.AttributeSet_._getIdAttribute9007 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getIdAttribute", "()Ljava/lang/String;");
			global::android.util.AttributeSet_._getClassAttribute9008 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getClassAttribute", "()Ljava/lang/String;");
			global::android.util.AttributeSet_._getIdAttributeResourceValue9009 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getIdAttributeResourceValue", "(I)I");
			global::android.util.AttributeSet_._getStyleAttribute9010 = @__env.GetMethodIDNoThrow(global::android.util.AttributeSet_.staticClass, "getStyleAttribute", "()I");
		}
	}
}
