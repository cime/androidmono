namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteMisuseException : android.database.sqlite.SQLiteException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteMisuseException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteMisuseException4807;
		public SQLiteMisuseException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteMisuseException.staticClass, global::android.database.sqlite.SQLiteMisuseException._SQLiteMisuseException4807);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteMisuseException4808;
		public SQLiteMisuseException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteMisuseException.staticClass, global::android.database.sqlite.SQLiteMisuseException._SQLiteMisuseException4808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SQLiteMisuseException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteMisuseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteMisuseException"));
			global::android.database.sqlite.SQLiteMisuseException._SQLiteMisuseException4807 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteMisuseException.staticClass, "<init>", "()V");
			global::android.database.sqlite.SQLiteMisuseException._SQLiteMisuseException4808 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteMisuseException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}