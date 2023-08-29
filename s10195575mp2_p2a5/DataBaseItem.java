package ece.np.edu.s10195575mp2_p2a5;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import java.util.ArrayList;
import java.util.List;

public class DataBaseItem extends SQLiteOpenHelper {
    //Table and database name
    public static final String DATABASE_SPENT = "budget.db";
    public static final String TABLE_NAME = "budget_table";

    //Column name
    public static final String COL_ID = "ID";
    public static final String COL_CATEGORY = "Category";
    public static final String COL_AMOUNT = "Amount";

    public DataBaseItem(Context context) {
        super(context,DATABASE_SPENT, null, 1);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        //Create the table in the database
        db.execSQL("create table " + TABLE_NAME
                + " (ID INTEGER PRIMARY KEY AUTOINCREMENT, Category TEXT, Amount TEXT)");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS " + TABLE_NAME);
        onCreate(db);
    }

    public boolean InsertItemData (ItemClass itemClass) {
        //Creates database and table
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put(COL_CATEGORY, itemClass.getStrCategory());
        contentValues.put(COL_AMOUNT, itemClass.getStrAmount());
        long result = db.insert(TABLE_NAME, null, contentValues);
        if (result == -1) {
            return false;
        }
        else {
            return true;
        }
    }

    public List<ItemClass> getBudget() {
        List<ItemClass> returnList = new ArrayList<>();
        String queryString = "SELECT * FROM " + TABLE_NAME;

        //Get values from database
        SQLiteDatabase db = this.getReadableDatabase();

        Cursor cursor = db.rawQuery(queryString, null);
        if (cursor.moveToFirst()) {
            //Loop through the cursor to and create new item object
            do {
                //Get values from respective columns
                String itemCategory = cursor.getString(1);
                String itemAmount = cursor.getString(2);

                ItemClass itemClass = new ItemClass(itemCategory, itemAmount);
                returnList.add(itemClass);

            }while(cursor.moveToNext());
        }
        else {
            //do nothing
        }

        //Close cursor and database
        cursor.close();
        db.close();
        return returnList;
    }
}
