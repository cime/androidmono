namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BackupDataOutput : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BackupDataOutput(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeEntityHeader2319;
		public virtual int writeEntityHeader(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.backup.BackupDataOutput._writeEntityHeader2319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.backup.BackupDataOutput.staticClass, global::android.app.backup.BackupDataOutput._writeEntityHeader2319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeEntityData2320;
		public virtual int writeEntityData(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.backup.BackupDataOutput._writeEntityData2320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.backup.BackupDataOutput.staticClass, global::android.app.backup.BackupDataOutput._writeEntityData2320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static BackupDataOutput()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupDataOutput.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupDataOutput"));
			global::android.app.backup.BackupDataOutput._writeEntityHeader2319 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupDataOutput.staticClass, "writeEntityHeader", "(Ljava/lang/String;I)I");
			global::android.app.backup.BackupDataOutput._writeEntityData2320 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupDataOutput.staticClass, "writeEntityData", "([BI)I");
		}
		internal static void InitJNI()
		{
		}
	}
}