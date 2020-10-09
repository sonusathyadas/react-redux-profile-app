
import React, { Component } from 'react';
import { Card } from './Card';

export class ProfileList extends Component {


    componentDidMount(){
        this.props.fetchProfiles();
    }
    render() {
        let emptyResult = <div className="alert alert-info">
            <p className="text-center">No profiles found</p>
        </div>;

        let dataResult = <div className="row">
            {this.props.profiles.map(user => <Card key={user.id} user={user}></Card>)}
        </div>;

        return (
            <div className="row">
                <div className="col-md-12">
                    <h2>Profiles</h2>
                    {this.props.profiles.length === 0 ? emptyResult : dataResult}
                </div>
            </div>
        )
    }
}