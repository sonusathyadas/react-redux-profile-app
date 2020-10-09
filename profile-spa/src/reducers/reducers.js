import {profileReducer} from './profile-reducer';
import {combineReducers} from 'redux';

const reducers = combineReducers({
    profiles:profileReducer
})

export default reducers;