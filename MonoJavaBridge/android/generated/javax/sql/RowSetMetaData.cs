namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.RowSetMetaData_))]
	public partial interface RowSetMetaData : java.sql.ResultSetMetaData
	{
		void setScale(int arg0, int arg1);
		void setCurrency(int arg0, bool arg1);
		void setColumnCount(int arg0);
		void setAutoIncrement(int arg0, bool arg1);
		void setCaseSensitive(int arg0, bool arg1);
		void setSearchable(int arg0, bool arg1);
		void setNullable(int arg0, int arg1);
		void setSigned(int arg0, bool arg1);
		void setColumnDisplaySize(int arg0, int arg1);
		void setColumnLabel(int arg0, java.lang.String arg1);
		void setColumnName(int arg0, java.lang.String arg1);
		void setSchemaName(int arg0, java.lang.String arg1);
		void setPrecision(int arg0, int arg1);
		void setTableName(int arg0, java.lang.String arg1);
		void setCatalogName(int arg0, java.lang.String arg1);
		void setColumnType(int arg0, int arg1);
		void setColumnTypeName(int arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.RowSetMetaData))]
	internal sealed partial class RowSetMetaData_ : java.lang.Object, RowSetMetaData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RowSetMetaData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setScale30583;
		void javax.sql.RowSetMetaData.setScale(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setScale30583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setScale30583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCurrency30584;
		void javax.sql.RowSetMetaData.setCurrency(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setCurrency30584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setCurrency30584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnCount30585;
		void javax.sql.RowSetMetaData.setColumnCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnCount30585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnCount30585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAutoIncrement30586;
		void javax.sql.RowSetMetaData.setAutoIncrement(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setAutoIncrement30586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setAutoIncrement30586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCaseSensitive30587;
		void javax.sql.RowSetMetaData.setCaseSensitive(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setCaseSensitive30587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setCaseSensitive30587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSearchable30588;
		void javax.sql.RowSetMetaData.setSearchable(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setSearchable30588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setSearchable30588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNullable30589;
		void javax.sql.RowSetMetaData.setNullable(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setNullable30589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setNullable30589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSigned30590;
		void javax.sql.RowSetMetaData.setSigned(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setSigned30590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setSigned30590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnDisplaySize30591;
		void javax.sql.RowSetMetaData.setColumnDisplaySize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnDisplaySize30591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnDisplaySize30591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnLabel30592;
		void javax.sql.RowSetMetaData.setColumnLabel(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnLabel30592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnLabel30592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnName30593;
		void javax.sql.RowSetMetaData.setColumnName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnName30593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnName30593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSchemaName30594;
		void javax.sql.RowSetMetaData.setSchemaName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setSchemaName30594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setSchemaName30594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setPrecision30595;
		void javax.sql.RowSetMetaData.setPrecision(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setPrecision30595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setPrecision30595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTableName30596;
		void javax.sql.RowSetMetaData.setTableName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setTableName30596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setTableName30596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCatalogName30597;
		void javax.sql.RowSetMetaData.setCatalogName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setCatalogName30597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setCatalogName30597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnType30598;
		void javax.sql.RowSetMetaData.setColumnType(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnType30598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnType30598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnTypeName30599;
		void javax.sql.RowSetMetaData.setColumnTypeName(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._setColumnTypeName30599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._setColumnTypeName30599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly30600;
		bool java.sql.ResultSetMetaData.isReadOnly(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isReadOnly30600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isReadOnly30600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName30601;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnName30601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnName30601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount30602;
		int java.sql.ResultSetMetaData.getColumnCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnCount30602);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnCount30602);
		}
		internal static global::MonoJavaBridge.MethodId _getScale30603;
		int java.sql.ResultSetMetaData.getScale(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getScale30603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getScale30603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPrecision30604;
		int java.sql.ResultSetMetaData.getPrecision(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getPrecision30604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getPrecision30604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWritable30605;
		bool java.sql.ResultSetMetaData.isWritable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isWritable30605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isWritable30605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAutoIncrement30606;
		bool java.sql.ResultSetMetaData.isAutoIncrement(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isAutoIncrement30606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isAutoIncrement30606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCaseSensitive30607;
		bool java.sql.ResultSetMetaData.isCaseSensitive(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isCaseSensitive30607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isCaseSensitive30607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSearchable30608;
		bool java.sql.ResultSetMetaData.isSearchable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isSearchable30608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isSearchable30608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCurrency30609;
		bool java.sql.ResultSetMetaData.isCurrency(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isCurrency30609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isCurrency30609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNullable30610;
		int java.sql.ResultSetMetaData.isNullable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isNullable30610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isNullable30610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSigned30611;
		bool java.sql.ResultSetMetaData.isSigned(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isSigned30611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isSigned30611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnDisplaySize30612;
		int java.sql.ResultSetMetaData.getColumnDisplaySize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnDisplaySize30612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnDisplaySize30612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnLabel30613;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnLabel(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnLabel30613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnLabel30613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaName30614;
		global::java.lang.String java.sql.ResultSetMetaData.getSchemaName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getSchemaName30614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getSchemaName30614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTableName30615;
		global::java.lang.String java.sql.ResultSetMetaData.getTableName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getTableName30615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getTableName30615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogName30616;
		global::java.lang.String java.sql.ResultSetMetaData.getCatalogName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getCatalogName30616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getCatalogName30616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnType30617;
		int java.sql.ResultSetMetaData.getColumnType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnType30617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnType30617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnTypeName30618;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnTypeName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnTypeName30618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnTypeName30618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isDefinitelyWritable30619;
		bool java.sql.ResultSetMetaData.isDefinitelyWritable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._isDefinitelyWritable30619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._isDefinitelyWritable30619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnClassName30620;
		global::java.lang.String java.sql.ResultSetMetaData.getColumnClassName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_._getColumnClassName30620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSetMetaData_.staticClass, global::javax.sql.RowSetMetaData_._getColumnClassName30620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		static RowSetMetaData_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSetMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSetMetaData"));
			global::javax.sql.RowSetMetaData_._setScale30583 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setScale", "(II)V");
			global::javax.sql.RowSetMetaData_._setCurrency30584 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setCurrency", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setColumnCount30585 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnCount", "(I)V");
			global::javax.sql.RowSetMetaData_._setAutoIncrement30586 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setAutoIncrement", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setCaseSensitive30587 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setCaseSensitive", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setSearchable30588 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setSearchable", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setNullable30589 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setNullable", "(II)V");
			global::javax.sql.RowSetMetaData_._setSigned30590 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setSigned", "(IZ)V");
			global::javax.sql.RowSetMetaData_._setColumnDisplaySize30591 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnDisplaySize", "(II)V");
			global::javax.sql.RowSetMetaData_._setColumnLabel30592 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnLabel", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setColumnName30593 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setSchemaName30594 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setSchemaName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setPrecision30595 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setPrecision", "(II)V");
			global::javax.sql.RowSetMetaData_._setTableName30596 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setTableName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setCatalogName30597 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setCatalogName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._setColumnType30598 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnType", "(II)V");
			global::javax.sql.RowSetMetaData_._setColumnTypeName30599 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "setColumnTypeName", "(ILjava/lang/String;)V");
			global::javax.sql.RowSetMetaData_._isReadOnly30600 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isReadOnly", "(I)Z");
			global::javax.sql.RowSetMetaData_._getColumnName30601 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getColumnCount30602 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnCount", "()I");
			global::javax.sql.RowSetMetaData_._getScale30603 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getScale", "(I)I");
			global::javax.sql.RowSetMetaData_._getPrecision30604 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getPrecision", "(I)I");
			global::javax.sql.RowSetMetaData_._isWritable30605 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isWritable", "(I)Z");
			global::javax.sql.RowSetMetaData_._isAutoIncrement30606 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isAutoIncrement", "(I)Z");
			global::javax.sql.RowSetMetaData_._isCaseSensitive30607 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isCaseSensitive", "(I)Z");
			global::javax.sql.RowSetMetaData_._isSearchable30608 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isSearchable", "(I)Z");
			global::javax.sql.RowSetMetaData_._isCurrency30609 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isCurrency", "(I)Z");
			global::javax.sql.RowSetMetaData_._isNullable30610 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isNullable", "(I)I");
			global::javax.sql.RowSetMetaData_._isSigned30611 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isSigned", "(I)Z");
			global::javax.sql.RowSetMetaData_._getColumnDisplaySize30612 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnDisplaySize", "(I)I");
			global::javax.sql.RowSetMetaData_._getColumnLabel30613 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnLabel", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getSchemaName30614 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getSchemaName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getTableName30615 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getTableName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getCatalogName30616 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getCatalogName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._getColumnType30617 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnType", "(I)I");
			global::javax.sql.RowSetMetaData_._getColumnTypeName30618 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnTypeName", "(I)Ljava/lang/String;");
			global::javax.sql.RowSetMetaData_._isDefinitelyWritable30619 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "isDefinitelyWritable", "(I)Z");
			global::javax.sql.RowSetMetaData_._getColumnClassName30620 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSetMetaData_.staticClass, "getColumnClassName", "(I)Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}