package com.example.listviewconsqlite;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

public class AdmBaseDatosSQLite extends SQLiteOpenHelper {
    public AdmBaseDatosSQLite(Context context) {
        super(context, "lenguajes", null, 1);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL("CREATE TABLE lenguajes (" +
                "id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "imagen INTEGER, " +
                "titulo TEXT, " +
                "descripcion TEXT)");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS lenguajes");
        onCreate(db);
    }
}