package ece.np.edu.s10195575mp2_p2a5;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import java.util.List;

public class MenuActivity extends AppCompatActivity {

    Button btLogout, btOverview, btEdit, btRefresh;
    TextView tvBudgetLeft;
    float fltTotalAmount, fltAmount;

    private static final int REQUEST_CODE = 99;
    private View.OnClickListener editListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            Intent editor = new Intent(getBaseContext(), EditActivity.class);
            startActivity(editor);
        }
    };

    private View.OnClickListener logoutListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            finish();
        }
    };

    private View.OnClickListener refreshListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            finish();
            startActivity(getIntent());
        }
    };

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);

        btEdit = this.findViewById(R.id.btEdit);
        btLogout = this.findViewById(R.id.btLogout);
        btRefresh = this.findViewById(R.id.btRefresh);
        tvBudgetLeft = this.findViewById(R.id.tvBudgetLeft);

        btEdit.setOnClickListener(editListener);
        btLogout.setOnClickListener(logoutListener);
        btRefresh.setOnClickListener(refreshListener);
        try {
            DataBaseItem dataBaseItem = new DataBaseItem(getBaseContext());
            List<ItemClass> totalAmount = dataBaseItem.getBudget();
            for (int i = 0; i < totalAmount.size(); i++) {
                fltAmount = Float.parseFloat(totalAmount.get(i).getStrAmount());
                fltTotalAmount = fltTotalAmount + fltAmount;
            }
        }
        catch (IllegalArgumentException e) {
            fltTotalAmount = 0.0f;
        }

        tvBudgetLeft.setText(String.valueOf(fltTotalAmount));
    }
}