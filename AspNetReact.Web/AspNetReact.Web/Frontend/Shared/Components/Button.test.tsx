import * as React from 'react';
import Button from './Button';
import { shallow } from 'enzyme';

describe('Button component', () => {

	it('should contain <a> tag when used as a link', () => {
		const wrapper = shallow(<Button link={true} />);
		expect(wrapper.find('a')).toHaveLength(1);
	});

	it('should contain <button> tag when used as a button', () => {
		const wrapper = shallow(<Button link={false} />);
		expect(wrapper.find('button')).toHaveLength(1);
	});

});