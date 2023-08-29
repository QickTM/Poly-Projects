package ece.np.edu.s10195575mp2_p2a5;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import java.util.ArrayList;
import java.util.List;

public class DataBaseUser extends SQLiteOpenHelper {
    //Table and database name
    public static final String DATABASE_USER = "user.db";
    public static final String TABLE_NAME = "user_table";
    //Name of column
    public static final String COL_ID = "ID";
    public static final String COL_NAME = "Name";
    public static final String COL_PASSWORD = "Password";

    public DataBaseUser(Context context) {
        super(context, DATABASE_USER, null, 1);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        //Create the table in the database
        db.execSQL("CREATE TABLE " + TABLE_NAME
                + " (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Password TEXT)");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS " + TABLE_NAME);
        onCreate(db);
    }

    public boolean InsertUserData (UserClass userClass) {
        //Creates database and table
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put(COL_NAME, userClass.getStrName());
        contentValues.put(COL_PASSWORD, userClass.getStrPassword());
        long result = db.insert(TABLE_NAME, null, contentValues);
        if (result == -1) {
            return false;
        }
        else {
            return true;
        }
    }

    public List<UserClass> getUser() {
        List<UserClass> returnList = new ArrayList<>();
        String queryString = "SELECT * FROM " + TABLE_NAME;

        //Get dat from database
        SQLiteDatabase db = this.getReadableDatabase();

        Cursor cursor = db.rawQuery(queryString, null);
        if (cursor.moveToFirst()) {
            //Loop through the cursor to and create new item object
            do {
                //Get values from respective columns
                String Name = cursor.getString(1);
                String Password = cursor.getString(2);

                UserClass userClass = new UserClass(Name, Password);
                returnList.add(userClass);

            }while(cursor.moveToNext());
        }

        //Close cursor and database
        cursor.close();
        db.close();
        return returnList;
    }
}
