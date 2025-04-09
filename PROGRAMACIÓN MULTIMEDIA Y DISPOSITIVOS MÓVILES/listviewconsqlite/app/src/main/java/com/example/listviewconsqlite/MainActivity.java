package com.example.listviewconsqlite;

import android.annotation.SuppressLint;
import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.RadioButton;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    private ListView lista;
    private RadioButton radioButtonPulsado;
    private TextView mensaje;
    private AdmBaseDatosSQLite dbHelper;
    private Adaptador adaptador;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        lista = findViewById(R.id.lista);
        mensaje = findViewById(R.id.texto);
        dbHelper = new AdmBaseDatosSQLite(this);


        Button btnInsertar = findViewById(R.id.btnInsertar);
        Button btnBorrar = findViewById(R.id.btnBorrar);
        Button btnListar = findViewById(R.id.btnListar);

        btnInsertar.setOnClickListener(v -> insertarDatos());
        btnBorrar.setOnClickListener(v -> borrarDatos());
        btnListar.setOnClickListener(v -> listarDatos());

        listarDatos();
    }

    private void insertarDatos() {
        SQLiteDatabase db = dbHelper.getWritableDatabase();

        db.execSQL("DELETE FROM lenguajes");


        ContentValues registro = new ContentValues();

        registro.put("imagen", R.drawable.java);
        registro.put("titulo", "Java");
        registro.put("descripcion", "Plataforma informática de lenguaje de programación creada por Sun Microsystems en 1995.");
        db.insert("lenguajes", null, registro);

        registro.clear();
        registro.put("imagen", R.drawable.python);
        registro.put("titulo", "Python");
        registro.put("descripcion", "Utilizado en las aplicaciones web, el desarrollo de software, la ciencia de datos y el machine learning");
        db.insert("lenguajes", null, registro);

        registro.clear();
        registro.put("imagen", R.drawable.sql);
        registro.put("titulo", "SQL");
        registro.put("descripcion", "Conjunto de sentencias que permiten consultar y manipular datos almacenados en BBDD.");
        db.insert("lenguajes", null, registro);

        registro.clear();
        registro.put("imagen", R.drawable.kotlin);
        registro.put("titulo", "Kotlin");
        registro.put("descripcion", "Lenguaje de programación de código abierto y tipado estático, creado por la empresa JetBrains.");
        db.insert("lenguajes", null, registro);

        registro.clear();
        registro.put("imagen", R.drawable.swift);
        registro.put("titulo", "Swift");
        registro.put("descripcion", "Lenguaje de Apple para crear apps para iPhone, iPad, Mac, Apple Watch y Apple TV.");
        db.insert("lenguajes", null, registro);

        db.close();
        mensaje.setText("Lista de lenguajes INSERTADA.");
    }

    private void borrarDatos() {
        SQLiteDatabase db = dbHelper.getWritableDatabase();
        db.execSQL("DELETE FROM lenguajes");
        db.close();

        ArrayList<Object[]> datosVacios = new ArrayList<>();
        adaptador = new Adaptador(this, R.layout.entrada, datosVacios) {
            @Override
            public void onEntrada(Object entrada, View view) {
                if (entrada != null) {
                    configurarVista(entrada, view);
                }
            }
        };
        lista.setAdapter(adaptador);
        mensaje.setText("Lista de lenguajes BORRADA.");
    }

    @SuppressLint("SetTextI18n")
    private void listarDatos() {
        SQLiteDatabase db = dbHelper.getReadableDatabase();
        ArrayList<Object[]> datos = new ArrayList<>();

        Cursor cursor = db.rawQuery("SELECT * FROM lenguajes", null);
        while (cursor.moveToNext()) {
            int imagen = cursor.getInt(cursor.getColumnIndexOrThrow("imagen"));
            String titulo = cursor.getString(cursor.getColumnIndexOrThrow("titulo"));
            String descripcion = cursor.getString(cursor.getColumnIndexOrThrow("descripcion"));
            datos.add(new Object[]{imagen, titulo, descripcion});
        }
        cursor.close();
        db.close();

        adaptador = new Adaptador(this, R.layout.entrada, datos) {
            @Override
            public void onEntrada(Object entrada, View view) {
                if (entrada != null) {
                    configurarVista(entrada, view);
                }
            }
        };
        lista.setAdapter(adaptador);
        mensaje.setText("Lenguajes  con " + datos.size() + " registros LISTADOS.");
    }

    private void configurarVista(Object entrada, View view) {
        Object[] datos = (Object[]) entrada;
        TextView textoTitulo = view.findViewById(R.id.texto_titulo);
        TextView textoDatos = view.findViewById(R.id.texto_datos);
        ImageView imagen = view.findViewById(R.id.imagen);
        RadioButton miRadio = view.findViewById(R.id.boton);

        textoTitulo.setText((String) datos[1]);
        textoDatos.setText((String) datos[2]);
        imagen.setImageResource((int) datos[0]);

        miRadio.setOnClickListener(v -> {
            if (radioButtonPulsado != null) {
                radioButtonPulsado.setChecked(false);
            }
            radioButtonPulsado = miRadio;
            miRadio.setChecked(true);
            mensaje.setText("MARCADA UNA OPCIÓN");
        });
    }
}