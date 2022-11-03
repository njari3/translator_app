import React from "react";

const Input = ({ name, label, error, ...rest }) => {
    return (
        <div className="row form-group">
            <label htmlFor={name}>{label}</label>
            <input {...rest} name={name} id={name} className="form-control" />
            {error && <div className="alert alert-danger col-2">{error}</div>}
        </div>
    );
};

export default Input;
