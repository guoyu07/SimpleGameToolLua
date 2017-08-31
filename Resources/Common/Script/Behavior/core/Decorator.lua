require 'Common.Script.BehaviorTree.core.BaseNode'

local decorator = b3.Class("Decorator", b3.BaseNode)
b3.Decorator = decorator

function decorator:ctor(params)
	b3.BaseNode.ctor(self)
	
	if not params then
		params = {}
	end

	self.child = params.child or nil
end

function decorator:initialize(params)

end
