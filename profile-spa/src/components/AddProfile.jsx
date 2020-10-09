import React, { Component } from 'react';


export class AddProfile extends Component {
    constructor(props) {
        super(props);
        this.state={
            profile:{
                name:'',
                email:'',
                photo:'',
                phonenumber:'',
                sex:'M',
                birthdate:new Date(),
                address:'',
                city:'',
                country:''

            }
        }
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }
    handleChange(e) {    
        let updatedProfile = this.state.profile;
        updatedProfile[e.target.name]=e.target.value;    
        this.setState({
            profile:updatedProfile
        })
    }
    handleSubmit(e){
        this.props.addProfile(this.state.profile)
        .then(
            data=>{
                alert("saved successfully");
                this.props.history.push('/')
            },
            err=>{
                console.log(err)
                alert("Error while saving profile");
            }
        )
        e.preventDefault();
    }

    render() {
        return (
            <div className="row">
                <div className="col-md-6 mx-auto">
                    <h2>Create Profile</h2>
                    <form onSubmit={this.handleSubmit}>
                        <div className="form-row">
                            <div className="form-group col-md-6">
                                <label className="col-sm-2 control-label">Name</label>
                                <input type="text" value={this.state.profile.name} onChange={this.handleChange} className="form-control" name="name" required />
                            </div>
                            <div className="form-group col-md-6">
                                <label className="col-sm-2 control-label">Email</label>
                                <input type="email" value={this.state.profile.email} onChange={this.handleChange} name="email" className="form-control" required />
                            </div>
                        </div>
                        <div className="form-row">
                            <div className="form-group col-md-6">
                                <label className="col-sm-2 control-label">Photo</label>
                                <input type="text" value={this.state.profile.photo} onChange={this.handleChange} className="form-control" name="photo" />
                            </div>
                            <div className="form-group col-md-6">
                                <label className="col-sm-2 control-label">Sex</label>
                                <select name="sex" value={this.state.profile.sex} onChange={this.handleChange} className="form-control" id="">
                                    <option value="M">Male</option>
                                    <option value="F">Female</option>
                                </select>
                            </div>
                        </div>
                        <div className="form-row">
                            <div className="form-group col-md-6">
                                <label className="col-sm-2 control-label">Birthday</label>                                
                                <input type="date" value={this.state.profile.birthdate} onChange={this.handleChange} name="birthdate" className="form-control" />
                            </div>
                            <div className="form-group col-md-6">
                                <label className="col-sm-2 control-label">Phone</label>
                                <input type="tel" value={this.state.profile.phonenumber} onChange={this.handleChange} name="phonenumber" className="form-control" />
                            </div>
                        </div>
                        <div className="form-row">
                            <div className="form-group col-md-6">
                                <label className="col-sm-2 control-label">Address</label>
                                <input type="text" value={this.state.profile.address} onChange={this.handleChange} name="address" className="form-control" />
                            </div>
                            <div className="form-group col-md-6">
                                <label className="col-sm-2 control-label">City</label>
                                <input type="text" value={this.state.profile.city} onChange={this.handleChange} name="city" className="form-control" />
                            </div>
                        </div>
                        <div className="form-row">
                            <div className="form-group col-md-6">
                                <label className="col-sm-2 control-label">Country</label>
                                <input type="text" value={this.state.profile.country} onChange={this.handleChange} name="country" className="form-control" />
                            </div>
                        </div>
                        <div className="form-row">
                            <div className="form-group col-md-12 text-center">
                                <button type="submit" className="btn btn-primary" >Save</button>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        )
    }
}