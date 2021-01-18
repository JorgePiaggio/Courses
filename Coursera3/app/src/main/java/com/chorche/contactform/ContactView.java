package com.chorche.contactform;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;


public class ContactView extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_contact_view);

        final Button buttonBack= findViewById(R.id.button);
        Bundle parametross =getIntent().getExtras();

        TextView nombre= (TextView) findViewById(R.id.textView4);
        TextView fecha= (TextView) findViewById(R.id.textView5);
        TextView tel= (TextView)findViewById(R.id.textView6);
        TextView mail= (TextView)findViewById(R.id.textView7);
        TextView desc= (TextView)findViewById(R.id.textView8);

        nombre.setText(parametross.getString(getResources().getString(R.string.pname)));
        tel.setText(parametross.getString(getResources().getString(R.string.pphone)));
        mail.setText(parametross.getString(getResources().getString(R.string.pmail)));
        desc.setText(parametross.getString(getResources().getString(R.string.pdesc)));
        fecha.setText(parametross.getString(getResources().getString(R.string.pnacimiento)));

        buttonBack.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
               ContactView.super.onBackPressed();
            }
        });
    }


}