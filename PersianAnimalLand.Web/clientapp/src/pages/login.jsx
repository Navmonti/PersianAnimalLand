import React, { useState } from 'react';
import axios from 'axios';

const Login = () => {

    const [Username, setUsername] = useState()
    const [Password, setPassword] = useState()

    const _onClick = () => { 
        const dataSet = {
            Username: Username,
            Password: Password
        }
        axios.post('https://localhost:44300/api/User/Login', dataSet )
    }

    




    return (
        <div className="container pb-xlg pt-xlg page">
            <div className="row">
                <div className="login pt-xlg pb-xlg">
                    <div className="col-md-12">
                        <div className="input-group mb-3">
                            <div className="input-group-prepend">
                                <span className="input-group-text" id="basic-addon1">@</span>
                            </div>
                            <input type="text" className="form-control" placeholder="Username" aria-label="Username" aria-describedby="basic-addon1" />
                        </div>
                    </div>
                    <div className="col-md-12">
                        <div className="input-group mb-3">
                            <div className="input-group-prepend">
                                <span className="input-group-text" id="basic-addon1">@</span>
                            </div>
                            <input type="password" className="form-control" placeholder="Password" aria-label="Password" aria-describedby="basic-addon1" />
                        </div>

                    </div>
                    <div className="col-md-12">
                        <div className="row">
                            <div className="col-md-6">
                                <input type="button" value="Login" className="btn btn-general pull-right" />
                            </div>
                            <div className="col-md-6">
                                <input type="submit" value="Sign Up" className="btn btn-general pull-left" onClick={_onClick()} />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Login;