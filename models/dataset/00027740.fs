FeatureScript 2180;
import(path : "onshape/std/geometry.fs", version : "2180.0");
import(path : "onshape/std/common.fs", version : "2180.0");
const mm = millimeter;
const VERTEX = EntityType.VERTEX;
const EDGE = EntityType.EDGE;
const FACE = EntityType.FACE;
const BODY = EntityType.BODY;
function v(x, y){return vector(x, y);}
function OD(order){return orderDisambiguation(order);}
function OSD(set){return originalSetDisambiguation(set);}
function TD(topology){return topologyDisambiguation(topology);}
function TDD(query){return trueDependencyDisambiguation(query);}
function sQuery(a, b, c) {return sketchEntityQuery(a, b, c);}

annotation { "Feature Type Name" : "Feature", "Feature Type Description" : "" }
export const myFeature = defineFeature(function(context is Context, id is Id, definition is map)
    precondition{}
    {
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0", {"start": v(0, 0) * mm, "end": v(114.3, 0) * mm});
            skLineSegment(sketch, "E1", {"start": v(0, 63.5) * mm, "end": v(0, 0) * mm});
            skArc(sketch, "E2", {"start": v(152.4, 63.5) * mm, "mid": v(147.38683891804763, 61.56114833258547) * mm, "end": v(145.36025887887237, 56.58280491668348) * mm});
            skLineSegment(sketch, "E3", {"start": v(152.4, 63.5) * mm, "end": v(0, 63.5) * mm});
            skArc(sketch, "E4", {"start": v(114.3, 0) * mm, "mid": v(137.40193339575302, 24.134977349873388) * mm, "end": v(145.36025887887237, 56.58280491668348) * mm});
            skLineSegment(sketch, "E5", {"start": v(0, 97.65031188726425) * mm, "end": v(0, 75.17341524362564) * mm, "construction": true});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]});
            var Q1;
            Q1=sQuery(id+"F0.wireOp",EDGE,"E5");
            revolve(context, id + "F1", {"entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"aa613f5e-7d39-44fd-9bb5-3c35a3a67bad")])]});
            var Q1;
            Q1=makeQuery(id+"F1.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E3")])]});
            shell(context, id + "F2", {"entities" : qUnion([Q0, Q1]), "thickness" : 2.54 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Right.planeOp"),FACE);
            cPlane(context, id + "F3", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 203.2 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F3.planeOp",FACE);
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E6.rect.bottom", {"start": v(19.05, 50.8) * mm, "end": v(-19.05, 50.8) * mm});
            skLineSegment(sketch, "E6.rect.top", {"start": v(19.05, 57.15) * mm, "end": v(-19.05, 57.15) * mm});
            skPoint(sketch, "E6.rect.middle", {"position": v(0, 53.975) * mm});
            skArc(sketch, "E7", {"start": v(19.05, 50.8) * mm, "mid": v(22.225, 53.975) * mm, "end": v(19.05, 57.15) * mm});
            skArc(sketch, "E8", {"start": v(-19.05, 57.15) * mm, "mid": v(-22.225, 53.975) * mm, "end": v(-19.05, 50.8) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F4", true);
            var Q1;
            Q1=makeQuery(id+"F1.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E4")])]});
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "endBound" : BoundingType.UP_TO_SURFACE, "oppositeDirection" : true, "endBoundEntityFace" : qUnion([Q1]), "depth" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skFitSpline(sketch, "E9", {"points": [v(203.75564694404602, 51.17695778608322) * mm, v(255.8901309967041, 63.502877950668335) * mm, v(313.9219582080841, 79.80705052614212) * mm, v(382.178395986557, 80.35974204540253) * mm, v(459.27780866622925, 63.22653591632843) * mm], "startDerivative": vector(331.95406984751406, -4.891227963424782) * mm, "endDerivative": vector(199.29061662132773, -83.03775692555382) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F4.wireOp",EDGE,"E6.rect.bottom"),sQuery(id+"F4.wireOp",EDGE,"E6.rect.top"),sQuery(id+"F4.wireOp",EDGE,"E7"),sQuery(id+"F4.wireOp",EDGE,"E8")])],"isStart":true});
            var Q1;
            Q1=sQuery(id+"F6.wireOp",EDGE,"E9");
            sweep(context, id + "F7", {"operationType" : NewBodyOperationType.ADD, "profiles" : qUnion([Q0]), "path" : qUnion([Q1])});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0")])]});
            var sketch = newSketch(context, id + "F8", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E10.0.0", {"center": v(0, 0) * mm, "radius": 114.3 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F8", true);
            extrude(context, id + "F9", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 9.525 * mm, "hasDraft" : true, "draftAngle" : 30 * degree, "draftPullDirection" : true});
        }
    });