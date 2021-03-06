namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RingtonePreference : android.preference.Preference, android.preference.PreferenceManager.OnActivityResultListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RingtonePreference()
		{
			InitJNI();
		}
		protected RingtonePreference(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick6966;
		protected override void onClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._onClick6966);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onClick6966);
		}
		internal static global::MonoJavaBridge.MethodId _onActivityResult6967;
		public virtual bool onActivityResult(int arg0, int arg1, android.content.Intent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.RingtonePreference._onActivityResult6967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onActivityResult6967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onGetDefaultValue6968;
		protected override global::java.lang.Object onGetDefaultValue(android.content.res.TypedArray arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.RingtonePreference._onGetDefaultValue6968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onGetDefaultValue6968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onSetInitialValue6969;
		protected override void onSetInitialValue(bool arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._onSetInitialValue6969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onSetInitialValue6969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToHierarchy6970;
		protected override void onAttachedToHierarchy(android.preference.PreferenceManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._onAttachedToHierarchy6970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onAttachedToHierarchy6970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRingtoneType6971;
		public virtual int getRingtoneType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.preference.RingtonePreference._getRingtoneType6971);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._getRingtoneType6971);
		}
		internal static global::MonoJavaBridge.MethodId _setRingtoneType6972;
		public virtual void setRingtoneType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._setRingtoneType6972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._setRingtoneType6972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShowDefault6973;
		public virtual bool getShowDefault() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.RingtonePreference._getShowDefault6973);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._getShowDefault6973);
		}
		internal static global::MonoJavaBridge.MethodId _setShowDefault6974;
		public virtual void setShowDefault(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._setShowDefault6974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._setShowDefault6974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShowSilent6975;
		public virtual bool getShowSilent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.RingtonePreference._getShowSilent6975);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._getShowSilent6975);
		}
		internal static global::MonoJavaBridge.MethodId _setShowSilent6976;
		public virtual void setShowSilent(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._setShowSilent6976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._setShowSilent6976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareRingtonePickerIntent6977;
		protected virtual void onPrepareRingtonePickerIntent(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._onPrepareRingtonePickerIntent6977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onPrepareRingtonePickerIntent6977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveRingtone6978;
		protected virtual void onSaveRingtone(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference._onSaveRingtone6978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onSaveRingtone6978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreRingtone6979;
		protected virtual global::android.net.Uri onRestoreRingtone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.RingtonePreference._onRestoreRingtone6979)) as android.net.Uri;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._onRestoreRingtone6979)) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _RingtonePreference6980;
		public RingtonePreference(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._RingtonePreference6980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RingtonePreference6981;
		public RingtonePreference(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._RingtonePreference6981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RingtonePreference6982;
		public RingtonePreference(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.RingtonePreference.staticClass, global::android.preference.RingtonePreference._RingtonePreference6982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.RingtonePreference.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/RingtonePreference"));
			global::android.preference.RingtonePreference._onClick6966 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onClick", "()V");
			global::android.preference.RingtonePreference._onActivityResult6967 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onActivityResult", "(IILandroid/content/Intent;)Z");
			global::android.preference.RingtonePreference._onGetDefaultValue6968 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;");
			global::android.preference.RingtonePreference._onSetInitialValue6969 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onSetInitialValue", "(ZLjava/lang/Object;)V");
			global::android.preference.RingtonePreference._onAttachedToHierarchy6970 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V");
			global::android.preference.RingtonePreference._getRingtoneType6971 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "getRingtoneType", "()I");
			global::android.preference.RingtonePreference._setRingtoneType6972 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "setRingtoneType", "(I)V");
			global::android.preference.RingtonePreference._getShowDefault6973 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "getShowDefault", "()Z");
			global::android.preference.RingtonePreference._setShowDefault6974 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "setShowDefault", "(Z)V");
			global::android.preference.RingtonePreference._getShowSilent6975 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "getShowSilent", "()Z");
			global::android.preference.RingtonePreference._setShowSilent6976 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "setShowSilent", "(Z)V");
			global::android.preference.RingtonePreference._onPrepareRingtonePickerIntent6977 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onPrepareRingtonePickerIntent", "(Landroid/content/Intent;)V");
			global::android.preference.RingtonePreference._onSaveRingtone6978 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onSaveRingtone", "(Landroid/net/Uri;)V");
			global::android.preference.RingtonePreference._onRestoreRingtone6979 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "onRestoreRingtone", "()Landroid/net/Uri;");
			global::android.preference.RingtonePreference._RingtonePreference6980 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.RingtonePreference._RingtonePreference6981 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.preference.RingtonePreference._RingtonePreference6982 = @__env.GetMethodIDNoThrow(global::android.preference.RingtonePreference.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
