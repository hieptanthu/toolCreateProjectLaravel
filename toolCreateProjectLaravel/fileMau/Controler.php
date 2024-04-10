<?php

namespace App\Http\modelName;

use App\Models\modelName;

use Illuminate\Http\Request;



class modelNamecategoryControler extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        $modelName = modelName::orderBy("id", "desc")->paginate();

        return view("modelName.index", ["dd" => $modelName]);
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create(modelName $modelName)
    {

        return view("modelName.create", ["dd" => $modelName]);
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $data = $request->validate([
            Datarequest
        ]);

        modelName::create($data);


        return redirect()->route("modelName.index")->with('message', 'Category was created successfully.');

    }

    /**
     * Display the specified resource.
     */
    public function show(modelName $modelName)
    {
        return view("modelName.show", ["dd" => $modelName]);
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit($id)
    {
        $modelName = modelName::findOrFail($id); // Retrieve category by ID
        return view('modelName.update', ["dd" => $modelName]);
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, $id)
    {
        $data = $request->validate([
            Datarequest
        ]);

        $modelName = modelName::findOrFail($id); // Retrieve category by ID
        $modelName->update($data);


        return to_route('modelName.index')->with('message', 'Note was updated');
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(modelName $modelName)
    {
        $modelName::delete();
        return view("modelName.index");
    }

   
}
