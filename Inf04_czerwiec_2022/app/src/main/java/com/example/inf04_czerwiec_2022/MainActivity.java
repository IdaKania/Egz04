package com.example.inf04_czerwiec_2022;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    TextView textView;
    int number = 0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        textView = findViewById(R.id.numberOfLikes);
    }
    public void incrementation(View v) {
        number++;
        textView.setText(String.valueOf(number));
    }

    public void decrementation(View v) {
        if(number>0) {
            number--;
            textView.setText(String.valueOf(number));
        }
    }
}