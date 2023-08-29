package ece.np.edu.s10195575mp2_p2a5;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Spinner;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import java.util.ArrayList;
import java.util.List;

public class EditActivity extends AppCompatActivity {
    Button btAdd;
    EditText etAmount;
    ListView listView;
    Spinner spCategory;
    String strCategory;

    ItemClass itemClass;
    DataBaseItem itemDb;

    private View.OnClickListener addListener = new View.OnClickListener() {
        @Override
        public void onClick(View v) {
            if (etAmount.getText().toString().equals("")) {
                Toast.makeText(getBaseContext(), "Please enter an amount", Toast.LENGTH_SHORT).show();
            }
            else {
                //Input values into the database table
                String strAmount = etAmount.getText().toString();
                itemClass = new ItemClass(strCategory, strAmount);
                itemDb.InsertItemData(itemClass);
            }

            itemDb = new DataBaseItem(getBaseContext());
            List<ItemClass> allItems = itemDb.getBudget();
            ArrayList<String> list = new ArrayList<>();
            for (int i = 0; i < allItems.size(); i++) {
                list.add(allItems.get(i).getStrCategory() + " ($" + allItems.get(i).getStrAmount() + ")");
            }

            ArrayAdapter itemArrayAdapter = new ArrayAdapter<>(EditActivity.this, android.R.layout.simple_list_item_1, list);
            listView.setAdapter(itemArrayAdapter);

            etAmount.setText("");
            etAmount.findFocus();
            Toast.makeText(getBaseContext(), "Updated Spending", Toast.LENGTH_SHORT).show();
        }
    };

    private AdapterView.OnItemSelectedListener categoryListener = new AdapterView.OnItemSelectedListener() {
        @Override
        public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
            String str = parent.getItemAtPosition(position).toString();
            if (parent.getId() == R.id.spCategory) {
                strCategory = str;
            }

            Toast.makeText(getBaseContext(), strCategory + "Selected", Toast.LENGTH_SHORT).show();
        }

        @Override
        public void onNothingSelected(AdapterView<?> parent) {
        }
    };

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_edit);

        //Cast items in the layout xml
        btAdd = this.findViewById(R.id.btAdd);
        etAmount = this.findViewById(R.id.etAmount);
        listView = this.findViewById(R.id.listView);
        spCategory = this.findViewById(R.id.spCategory);

        itemDb = new DataBaseItem(getBaseContext());
        List<ItemClass> allItems = itemDb.getBudget();
        ArrayList<String> list = new ArrayList<>();
        for (int i = 0; i < allItems.size(); i++) {
            list.add(allItems.get(i).getStrCategory() + " ($" + allItems.get(i).getStrAmount() + ")");
        }

        ArrayAdapter itemArrayAdapter = new ArrayAdapter<>(EditActivity.this, android.R.layout.simple_list_item_1, list);
        listView.setAdapter(itemArrayAdapter);

        btAdd.setOnClickListener(addListener);
        spCategory.setOnItemSelectedListener(categoryListener);
    }
}