package com.chorche.contactform;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.CalendarView;
import com.google.android.material.textfield.TextInputEditText;

import java.text.SimpleDateFormat;
import java.util.Date;

public class MainActivity extends AppCompatActivity {
    String selectedDate;

    public MainActivity() {
        this.selectedDate = "";
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        CalendarView userDate= (CalendarView) findViewById(R.id.calendarView4);
        SimpleDateFormat sdf=new SimpleDateFormat("dd/MM/yyyy");
        selectedDate= sdf.format(new Date(userDate.getDate()));

        userDate.setOnDateChangeListener(new CalendarView.OnDateChangeListener() {
            @Override
            public void onSelectedDayChange(@NonNull CalendarView view, int year, int month, int dayOfMonth) {
                selectedDate=dayOfMonth +"/"+(month+1)+"/"+year;
            }
        });

        final Button button = (Button)findViewById(R.id.button2);

        button.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {
                TextInputEditText name= (TextInputEditText)findViewById(R.id.InputName);
                TextInputEditText phone= (TextInputEditText)findViewById(R.id.InputTelefono);
                TextInputEditText mail = (TextInputEditText)findViewById(R.id.InputMail);
                TextInputEditText description = (TextInputEditText)findViewById(R.id.InputDescripcion);

                Intent i= new Intent(v.getContext(), ContactView.class);
                i.putExtra(getResources().getString(R.string.pname),name.getText().toString());
                i.putExtra(getResources().getString(R.string.pphone),phone.getText().toString());
                i.putExtra(getResources().getString(R.string.pmail),mail.getText().toString());
                i.putExtra(getResources().getString(R.string.pdesc),description.getText().toString());
                i.putExtra(getResources().getString(R.string.pnacimiento),selectedDate);
                startActivity(i);
            }
        });



    };
}