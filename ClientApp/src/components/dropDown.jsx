import React, { Component } from "react";
// or less ideally
const DropDown = ({ items, textProperty, onItemSelect }) => {
  return (
    <div>
      <div className="form-group">
        <select className=" row form-control">
          <option>{textProperty}</option>
          {items.map((option) => (
            <option
              key={option.id}
              value={option.id}
              onClick={() => onItemSelect(option)}
            >
              {option.name}
            </option>
          ))}
        </select>
      </div>
    </div>
  );
};

export default DropDown;
